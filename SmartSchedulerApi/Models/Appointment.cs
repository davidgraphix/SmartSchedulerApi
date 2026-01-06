namespace SmartSchedulerApi.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
