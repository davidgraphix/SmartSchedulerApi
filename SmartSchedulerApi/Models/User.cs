namespace SmartSchedulerApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public int RoleId { get; set; }
        public string Role { get; set; } = null!;
    }
}
