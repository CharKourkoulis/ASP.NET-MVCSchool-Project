using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMVCSchool.Models
{

    public enum Courses
    {
        [Display(Name = "C# Full Time")]
        Csharp_full,
        [Display(Name = "Java Full Time")]
        Java_full,
        [Display(Name = "C# Part Time")]
        Csharp_part,
        [Display(Name = "Java Part Time")]
        Java_part,
        [Display(Name = "JavaScript Full Time")]
        Javascript_full,
        [Display(Name = "JavaScript Part Time")]
        Javascript_part
    }
    public class Student
    {
        public int Id { get; set; }

        [Display(Name ="First Name")]
        [MinLength(3)]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MinLength(3)]
        [MaxLength(15)]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Tuition Fees")]
        public int TuitionFees { get; set; }

        public Courses Course { get; set; }

        public string ImageURL { get; set; }
    }
}