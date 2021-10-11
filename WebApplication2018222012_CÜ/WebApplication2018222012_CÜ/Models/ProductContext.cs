using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace WebApplication2018222012_CÜ.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext():base("productconn")
        {
            Database.SetInitializer( new ProductInitalizer());
        }
        public DbSet<Product> Products { get; set; }
    }
}