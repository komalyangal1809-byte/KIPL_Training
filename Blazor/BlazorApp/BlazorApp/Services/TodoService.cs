using System.Net.Http.Json;
namespace BlazorApp.Services
{
    public class TodoService
    {
        private readonly HttpClient _http;
        private readonly string apiUrl = "https://localhost:7089/api/tasks";
        public TodoService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<string>> GetTasks()
        {
            return await _http.GetFromJsonAsync<List<string>>(apiUrl);
        }
        public async Task AddTask(string task)
        {
            await _http.PostAsJsonAsync(apiUrl, task);
        }
        public async Task DeleteTask(String task)
        {
            await _http.SendAsync(new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(apiUrl),
                Content = JsonContent.Create(task)
            });
        }
    }
}
