using AdminManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminManagement.Data
{
    public class AdminManagementContext : DbContext
    {
        public AdminManagementContext(DbContextOptions<AdminManagementContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }*/
    }
}
