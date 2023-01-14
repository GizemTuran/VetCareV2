using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VetCare.Models;

namespace VetCare.Controllers
{
    public class LoginController : Controller
    {
        VetCareDbProject db = new VetCareDbProject();

        // GET: Login
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }
        //[Authorize]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Login login) //viewdan posta gelir datalar.
        {
            try
            {
                db.Logins.Add(login);
                db.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = login.FirstName + " " + login.LastName + "successfully registered.";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return View();
        }
        //Login
        // [AllowAnonymous]
        public ActionResult Login()
        {

            return View();
        }
        //[AllowAnonymous]

        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (login.FirstName == "admin") //admin adı ile kullanıcı oluşturulması engellenir.
            {
                return View();
            }
            var usr = db.Logins.SingleOrDefault(u => u.Email == login.Email && u.Password == login.Password);

            if (usr != null)
            {
                //FormsAuthentication.SetAuthCookie(usr.FirstName, false);
                Session["ID"] = usr.ID.ToString();
                Session["FirstName"] = usr.FirstName.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("loginerror", "Email or Password is wrong. Please try again..");
            }
            return View();
        }
        /* public ActionResult LoggedIn()
         {
             if (Session["ID"]!=null)
             {
                 return View();
             }
             else
             {
                 return RedirectToAction("Login");
             }
         }*/
        public ActionResult Logout()
        {
            if (Session["ID"] != null)
            {
                //FormsAuthentication.SignOut();
                Session.Remove("ID");
                Session.Remove("FirstName");
                return RedirectToAction("Login");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    }
}