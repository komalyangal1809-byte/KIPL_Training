using System.Net.Http.Json;
using System.Threading.Tasks;
using BookApp.Models;
namespace BookApp.Services
{
    public class BooksService
    {
        private readonly HttpClient _http;
        public readonly string apiUrl= "https://localhost:7155/api/books";

        
        public BooksService(HttpClient http)
        {
            _http = http;
        }
      
        public async Task<List<Book>> GetBooks()
        {
            return await _http.GetFromJsonAsync<List<Book>>(apiUrl);
        }
        public async Task AddBooks(Book books)
        {
            await  _http.PostAsJsonAsync(apiUrl, books);
            
        }
    }
}
