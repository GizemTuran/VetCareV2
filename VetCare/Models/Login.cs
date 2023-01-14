using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VetCare.Models
{
    [Table("Login")]

    public class Login
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Firstname is required!")]
        [StringLength(200)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required!")]
        [StringLength(200)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+.[A-Za-z]{2,4}")]
        [StringLength(200)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        //[RegularExpression(@"^(?=.[a-z])(?=.[A-Z])(?=.*\d).{8,15}$")]
        [StringLength(200)]
        public string Password { get; set; }
    }
}