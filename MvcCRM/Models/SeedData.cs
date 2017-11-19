using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCRM.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCRMContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcCRMContext>>()))
            {
                // Look for any users.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                     new User
                     {
                         Name = "Ola",
                         Surname = "Nowak",
                         DateOfBirth = DateTime.Parse("1989-01-11"),
                         Login = "olaN"
                     },

                     new User
                     {
                         Name = "Adam",
                         Surname = "Blocki",
                         DateOfBirth = DateTime.Parse("1923-10-23"),
                         Login = "blocki"
                     },

                     new User
                     {
                         Name = "Brygida",
                         Surname = "Loczek",
                         DateOfBirth = DateTime.Parse("1998-01-08"),
                         Login = "loczek"
                     },

                   new User
                   {
                       Name = "Antoni",
                       Surname = "Komorka",
                       DateOfBirth = DateTime.Parse("1949-01-22"),
                       Login = "kom"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
