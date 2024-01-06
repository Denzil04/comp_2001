using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using prodject2001.Models;
using prodject2001.Controllers;

namespace prodject2001.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Activity> Activities { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships and database schema details here
        }

        public static implicit operator UserDbContext(UserController v)
        {
            throw new NotImplementedException();
        }
    }
}
