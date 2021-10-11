using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2018222012_CÜ.Models;

namespace WebApplication2018222012_CÜ.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (AccountContext ac = new AccountContext())
            {
                return View(ac.Accounts.ToList());
            }
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Account account)
        {
            if (ModelState.IsValid)
            {
                using (AccountContext ac = new AccountContext())
                {
                    ac.Accounts.Add(account);
                    ac.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.Username + " Created ";
            }
            return View();
        }

        //Login:
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account user)
        {
            using (AccountContext ac = new AccountContext())
            {
              
                var usr = ac.Accounts.Single(u => u.Username == user.Username && u.Password == user.Password);
                if (usr != null)
                {
                    Session["Id"] = usr.Id.ToString();
                    Session["Username"] = usr.Username.ToString();
                    return RedirectToAction("Product","Home");
                }
               
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong");
                }
               
              
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            return View();
        }
    }
}
