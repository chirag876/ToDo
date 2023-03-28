using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDo.Data;
using ToDo.Data.Interface;
using ToDo.Model;

namespace ToDo.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class ToDoController : Controller
    {
        public ITask task;
        public ToDoController(ITask task)
        {
            this.task = task;
        }

        [HttpGet]
    
        public async Task<IActionResult> getall()
        {
            var result = await task.getall();
            return Ok(result);
        }

        [HttpPost]
      
        public async Task<IActionResult> post(Todo addtask)
        {
            var result = await task.post(addtask);
            return Ok(result);
        }

        [HttpPut]
        [Route("Put")]
        public async Task<IActionResult> Put(Todo updatask)
        {
            var result = await task.put(updatask);
            return Ok(result);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> delete(int TaskId)
        {
            var result = await task.delete(TaskId);
            return Ok(result);
        }


    }
}
