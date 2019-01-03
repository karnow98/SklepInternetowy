using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Pole imie jest wymagane")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole nazwisko jest wymagane")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Pole e-mail jest wymagane")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pole hasło jest wymagane")]
        public string Password { get; set; }
    }
}