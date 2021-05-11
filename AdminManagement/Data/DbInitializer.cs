using AdminManagement.Models;
using System;
using System.Linq;

namespace AdminManagement.Data
{
    public static class DbInitializer
    {
        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();

            // This will check if there's already data in the DB
            if(context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User{ FirstName="Henk", LastName="Kek" },
                new User{ FirstName="Jos", LastName="Smit" },
                new User{ FirstName="Eric", LastName="Test" },
            };
            foreach(User u in users)
            {
                context.Users.Add(u);
            }

            context.SaveChanges();
        }
    }
}
