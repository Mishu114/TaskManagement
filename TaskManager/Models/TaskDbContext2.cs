using Microsoft.EntityFrameworkCore;

namespace TaskManager.Models
{
    public class TaskDbContext2:DbContext
    {
        public TaskDbContext2(DbContextOptions<TaskDbContext2> options) : base(options)
        {
            
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
