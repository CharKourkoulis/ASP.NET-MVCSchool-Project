using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMVCSchool.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [MinLength(3)]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MinLength(3)]
        [MaxLength(15)]
        public string LastName { get; set; }
        public string Subject { get; set; }
        public Courses Course { get; set; }
        public string ImageURL { get; set; }
    }
}