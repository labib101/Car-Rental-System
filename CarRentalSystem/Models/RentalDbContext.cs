using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class RentalDbContext: DbContext
    {
        public DbSet<Banks> Bank { get; set; }
        public DbSet<BankingDetails> BankingDetail { get; set; }
        public DbSet<BookingDetails> BookingDetail { get; set; }
        public DbSet<CarDetails> CarDetail { get; set; }
        public DbSet<LoginAuthentication> Auth { get; set; }
        public DbSet<PaymentDetails> PaymentDetail { get; set; }
        public DbSet<UserDetails> User { get; set; }
        public DbSet<Coasters> Coaster { get; set; }
    }
}