using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace formAndValidation.Models
{
    public class Registration
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string Id { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        public Registration()
        {
            Dob = DateTime.Now;
        }
    }
}