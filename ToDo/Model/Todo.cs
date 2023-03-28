using System.ComponentModel.DataAnnotations;

namespace ToDo.Model
{
    public class Todo
    {
        [Key]
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ScheduleDate { get; set; }

        public int IsCompleted { get; set; }

    }
}
