using ToDo.Model;

namespace ToDo.Data.Interface
{
    public interface ITask
    {
        Task<List<Todo>> getall();
        Task<int> post(Todo addtask);
        Task<int> delete(int TaskId);
        Task<Todo> put(Todo todo);
    }
}
