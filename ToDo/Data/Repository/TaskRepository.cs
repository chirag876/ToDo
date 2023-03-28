using Microsoft.EntityFrameworkCore;
using ToDo.Data.Interface;
using ToDo.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ToDo.Data.Repository
{
    public class TaskRepository:ITask
    {
        private readonly TodoDbContext todoDbContext;
        public TaskRepository(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public async Task<List<Todo>> getall()
        {
            var result = await todoDbContext.todos.ToListAsync();
            return result;
        }

        public async Task<int> post(Todo addtask)
        {
            todoDbContext.todos.Add(addtask);
            await todoDbContext.SaveChangesAsync();
            return addtask.TaskId;
        }

        public async Task<Todo> put(Todo todo)
        {
          var result =   todoDbContext.todos.Where(x=>x.TaskId==todo.TaskId).FirstOrDefault();
            result.Description= todo.Description;
            result.Title= todo.Title;
            result.ScheduleDate= todo.ScheduleDate;
            result.IsCompleted= todo.IsCompleted;
            todoDbContext.SaveChanges();
            return result;
        }

        public async Task<int> delete(int TaskId)
        {
            var result = todoDbContext.todos.Where(x => x.TaskId == TaskId).FirstOrDefault();
            
                todoDbContext.todos.Remove(result);
            await todoDbContext.SaveChangesAsync();

            return TaskId;
        }
    }
}
