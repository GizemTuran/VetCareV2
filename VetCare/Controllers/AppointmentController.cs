using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VetCare.Models;

namespace VetCare.Controllers
{
    //[Authorize]
    public class AppointmentController : Controller
    {
        VetCareDbProject db =new VetCareDbProject();
        public ActionResult Appointment()
        {
            if (Session["ID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","Login");
            }
        }
        [HttpPost]
        public ActionResult Appointment(AppointmentViewModel appointmentViewModel)
        {
            
            Appointment appointment = new Appointment();
            appointment.Name = appointmentViewModel.Name;
            appointment.Email = appointmentViewModel.Email;
            appointment.Phone = appointmentViewModel.Phone;
            appointment.AddInfo = appointmentViewModel.AddInfo;
            appointment.Date = appointmentViewModel.Date;
            appointment.Gender = appointmentViewModel.GenderEnum.ToString();
            appointment.Reason = appointmentViewModel.ReasonEnum.ToString();

            db.Appointments.Add(appointment);
            db.SaveChanges();
        

            return View();
        }
        
    }
}