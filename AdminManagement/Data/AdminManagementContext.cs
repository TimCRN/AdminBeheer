// <copyright file="AdminManagementContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdminManagement.Data
{
    using AdminManagement.Models;
    using Microsoft.EntityFrameworkCore;

    public class AdminManagementContext : DbContext
    {
        public AdminManagementContext(DbContextOptions<AdminManagementContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<InventoryItem> InventoryItems { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Service> Services { get; set; }
    }
}
