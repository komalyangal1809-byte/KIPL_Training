using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        static List<string> tasks = new();

        [HttpGet]
        public List<string> GetTasks()
        {
            return tasks;
        }
        [HttpPost]

        public void AddTask([FromBody] string task)
        {
            tasks.Add(task);
        }
        [HttpDelete]
        public void DeleteTask([FromBody] string task)
        {
            tasks.Remove(task);
        }
    }
}
