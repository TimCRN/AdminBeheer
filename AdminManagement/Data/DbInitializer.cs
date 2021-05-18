﻿using AdminManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AdminManagement.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AdminManagementContext context)
        {
            // TODO: Change this for the production environment
            // Looks for pending migrations.
            // Rebuilds and seeds the DB if so.
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();

                #region Role Definition

                context.Roles.AddRange(new Role[]
                    {
                        new Role{ Name="Admin" },
                        new Role{ Name="Employee" },
                        new Role{ Name="Customer" }
                    });
                context.SaveChanges();

                #endregion

                #region Category Definition

                context.Categories.AddRange(new Category[]
                    {
                        new Category{ Name="IT Device" },
                    });
                context.SaveChanges();

                #endregion

                context.Users.AddRange(new User[]
                {
                    new User{ RoleId=1, FirstName="Henk", LastName="Kek", Email="henk@gmail.com" }
                });
                context.SaveChanges();

                context.InventoryItems.AddRange(new InventoryItem[]
                {
                    new InventoryItem{ UserId=1, CategoryId=1, Name="Laptop", Value=15 }
                });
                context.SaveChanges();

                context.Services.AddRange(new Service[] 
                {
                    new Service{ UserId=1, Name="Housekeeping", Description="A cleaning service.", Value=50 }
                });
                context.SaveChanges();
            }
        }
    }
}
