namespace SmartSchedulerApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsCompleted { get; set; }
        public int AssignedToId { get; set; }
        public User AssignedTo { get; set; } = null!; 
    }
}
