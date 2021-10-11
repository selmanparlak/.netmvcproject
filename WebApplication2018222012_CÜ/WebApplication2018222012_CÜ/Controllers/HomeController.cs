using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2018222012_CÜ.Models;
using System.Data.Entity;

namespace WebApplication2018222012_CÜ.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {     
            return View();
        }
        public ActionResult list()
        {
            using (ProductContext pc = new ProductContext())
            {
                return View(pc.Products.ToList());
            }
        }
        public ActionResult Product()
        {
            ProductContext pc1 = new ProductContext();
          
            return View(pc1);
        }
        [HttpGet]
        public ActionResult Productadd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Productadd(Product product)
        {
            ProductContext pc1 = new ProductContext();
                    pc1.Products.Add(product);
                    pc1.SaveChanges();   
            return View("Product", pc1);
        }
        [HttpPost]
        public ActionResult Productshow(int proid)
        {
            ProductContext productContext = new ProductContext();
            Models.Product p = productContext.Products.Find(proid);

            return View(p);
        }
        public ActionResult Edit(int id)
        {
            using (ProductContext pc = new ProductContext())
            {
                return View(pc.Products.Where(x => x.Id == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {       
                using (ProductContext pc = new ProductContext())
                {
                    pc.Entry(product).State = EntityState.Modified;
                    pc.SaveChanges();
                }
            return RedirectToAction("list", "Home");
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            using(ProductContext pc = new ProductContext())
            {
                Models.Product product = pc.Products.Where(x => x.Id == id).FirstOrDefault();
                pc.Products.Remove(product);
                pc.SaveChanges();
                

            }
            return RedirectToAction("list", "Home");
        }
    }
}