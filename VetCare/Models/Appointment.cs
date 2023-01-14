namespace VetCare.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment //dbye setlenen
    {
        public int ID { get; set; }

        [Required(ErrorMessage="Name is required!")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone is required!")]
        [StringLength(200)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [StringLength(200)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Date is required!")]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Gender is required!")]
        [StringLength(200)]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Reason is required!")]
        [StringLength(200)]
        public string Reason { get; set; }

        [StringLength(200)]
        public string AddInfo { get; set; }
    }
}
