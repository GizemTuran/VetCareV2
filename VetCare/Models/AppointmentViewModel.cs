using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VetCare.DataTypes;

namespace VetCare.Models
{
    public class AppointmentViewModel
    {
        //dropdown list ile enum alabilmek için bu view oluşturuldu.
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public Gender GenderEnum { get; set; } //dropdown listten enum seçilir model seçilip enuma atanır.

        public Reason ReasonEnum { get; set; }//dbye enum cinsinde data verilemedi.
        public string AddInfo { get; set; }

    }
}