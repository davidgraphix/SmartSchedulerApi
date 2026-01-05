using Microsoft.EntityFrameworkCore;
using SmartSchedulerApi.Models;

namespace SmartSchedulerApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }

    }
}
