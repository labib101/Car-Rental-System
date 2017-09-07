using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class DbSeeder: DropCreateDatabaseIfModelChanges<RentalDbContext>
    {
        protected override void Seed(RentalDbContext context)
        {
            LoginAuthentication Admin = new LoginAuthentication()
            {
                Email = "admin@gmail.com",
                Password = "123",
                AuthToken = "Admin"
            };
            context.Auth.Add(Admin);
            

            context.SaveChanges();
            base.Seed(context);
        }
    }
}