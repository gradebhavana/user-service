using UserMicroService.Models;
using Microsoft.EntityFrameworkCore;

namespace UserMicroService
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
