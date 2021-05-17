using AdminManagement.Controllers;
using AdminManagement.Data;
using AdminManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AdminManagement.Tests
{
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

            // Creating the Controller
            var controller = new UsersController(context);

            // Adding to the DB
            await controller.Create(new User() { FirstName = "Test", LastName = "Test" });

            // Check if added correctly
            var result = (await controller.GetAll()).ToArray();
            Assert.Single(result);
            Assert.Equal("Test", result[0].FirstName);
        }
        #endregion
    }
}
