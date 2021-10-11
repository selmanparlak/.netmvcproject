using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2018222012_CÜ.Models
{
    public class ProductInitalizer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            List<Product> p1 = new List<Product>();
            p1.Add(new Product { Id = 1, Productname = "c#", ProductCat = "Software", ProductImg = "/blue/images/includes/project1.jpg", Description = ".net,Microsoft SQL,Formapp" });
            p1.Add(new Product { Id = 2, Productname = "Management", ProductCat = "Business", ProductImg = "/blue/images/includes/project2.jpg", Description = "Work Manager" });
            p1.Add(new Product { Id = 3, Productname = "Sql", ProductCat = "Software", ProductImg = "/blue/images/includes/project3.jpg", Description = "Database" });
            p1.Add(new Product { Id = 4, Productname = "SAP", ProductCat = "Software", ProductImg = "/blue/images/includes/project4.jpg", Description = "abap" });
            p1.Add(new Product { Id = 5, Productname = "Security", ProductCat = "Software", ProductImg = "/blue/images/includes/project5.jpg", Description = "Cyber Security" });
            p1.Add(new Product { Id = 6, Productname = "Healthcare Management", ProductCat = "Management", ProductImg = "/blue/images/includes/project6.jpg", Description = "Healthcare" });
            p1.Add(new Product { Id = 7, Productname = "Project Management", ProductCat = "Management", ProductImg = "/blue/images/includes/project7.jpg", Description = "processes, methods, skills," });
            p1.Add(new Product { Id = 8, Productname = "Game Designer", ProductCat = "Software", ProductImg = "/blue/images/includes/project8.jpg", Description = "2D,3D" });
            p1.Add(new Product { Id = 9, Productname = "Game Developer", ProductCat = "Software", ProductImg = "/blue/images/includes/project9.jpg", Description = "Indie,RPG" });
            p1.Add(new Product { Id = 10, Productname = "economy 101", ProductCat = "Business", ProductImg = "/blue/images/includes/projectimage1.jpg", Description = "Basic Level" });

            foreach (var item in p1)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}