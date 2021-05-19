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
        public DbSet<Role> Roles { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
