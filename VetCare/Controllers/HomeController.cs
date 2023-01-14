using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VetCare.Models;

namespace VetCare.Controllers
{
    public class HomeController : Controller
    {
        VetCareDbProject db = new VetCareDbProject();

        public ActionResult Index()
        {
            var dbUserCheck = db.Logins.FirstOrDefault();
            if (dbUserCheck == null)
            {
                Login login = new Login();
                login.FirstName = "TestName";
                login.LastName = "LastName";
                login.Email = "test@gmail.com";
                login.Password = "1234";

                Login admin = new Login();
                login.FirstName = "admin";
                login.LastName = "admin";
                login.Email = "admin@gmail.com";
                login.Password = "admin";

                db.Logins.Add(login);
                db.Logins.Add(admin);
                db.SaveChanges();
            }

            return View();
        }

    }
}