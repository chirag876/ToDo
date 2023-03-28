using Microsoft.EntityFrameworkCore;
using ToDo.Model;

namespace ToDo.Data
{
    public class TodoDbContext:DbContext
    {
        public TodoDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Todo> todos { get; set; }
    }
}
