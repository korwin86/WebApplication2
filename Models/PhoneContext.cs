using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class PhoneContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

    }
}