namespace TEMA_7.Models
{
    public class TaskList
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
        public User User { get; set; }
    }
}