// <copyright file="Tests.cs" company="Zuyd">
// Copyright (c) Zuyd. All rights reserved.
// </copyright>

namespace AdminManagement.Tests
{
    using System.Linq;
    using System.Threading.Tasks;
    using AdminManagement.Controllers;
    using AdminManagement.Data;
    using AdminManagement.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Xunit;

    public class Tests
    {
        #region Integration Tests
        [Fact]
        public async Task UserTest()
        {
            // Creating the DB context
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AdminManagementContext>();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
            var context = new AdminManagementContext(optionsBuilder.Options);

            // Renew Testing DB
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();

            // Ensure a role is available to appoint to
            context.Roles.Add(new Role { Name = "Test" });

            // Creating the Controller
            var controller = new UsersController(context);

            // Adding to the DB
            await controller.Create(new User() { FirstName = "Test", LastName = "Test", Email = "test@test.com", RoleId = 1, PhoneNumber = "0123456789" });

            // Check if added correctly
            var result = (await controller.GetAll()).ToArray();
            Assert.Single(result);
            Assert.Equal("Test", result[0].FirstName);
        }
        #endregion

        #region Unit Tests
        [Fact]
        public void ValidUserUnitTest()
        {
            // Checks if fields in user are not null
            User testUser = new () { FirstName = "Test", LastName = "User", Email = "testuser@test.com", RoleId = 1, PhoneNumber = "0123456789" };
            Assert.NotNull(testUser.FirstName);
            Assert.NotNull(testUser.LastName);
            Assert.NotNull(testUser.Email);
            Assert.NotNull(testUser.PhoneNumber);
        }

        [Fact]
        public void UnitTest2()
        {
        }
        #endregion
    }
}
