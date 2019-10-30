using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMVCSchool.Models
{
    public enum Type
    {
        [Display(Name = "C#")]
        CSharp,      
        Java,
        Javascript
    }

    public enum Stream
    {
        [Display(Name = "Part Time")]
        PartTime,
        [Display(Name = "Full Time")]
        FullTime
    }

    public class Course
    {
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(10)]
        public string Title { get; set; }

        public Stream Stream { get; set; }
        public Type Type { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndDate { get; set; }
    }
}