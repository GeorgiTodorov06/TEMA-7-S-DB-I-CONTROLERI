namespace TEMA_7.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int TaskListId { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public TaskList TaskList { get; set; }
    }
}
