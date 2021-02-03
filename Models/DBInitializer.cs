using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Name = "Huawei P20", Price = 40000, Producer = "Huawei" });
            context.Phones.Add(new Phone() { Name = "LG G6 P20", Price = 37000, Producer = "LG" });
            context.Phones.Add(new Phone() { Name = "Samsung S9", Price = 58000, Producer = "Samsung" });

            base.Seed(context);
        }
    }
}