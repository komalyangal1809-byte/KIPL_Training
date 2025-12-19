using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BooksApi.Models ;
using System.ComponentModel;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        static List<Book> books = new();

        [HttpGet]
        public async Task<List<Book>> GetBooks()
        {
            return books;
        }
        [HttpPost]
        public void AddBook([FromBody] Book book)
        {
            books.Add(book);
        }
    }
}
