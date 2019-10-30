using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MyMVCSchool.Models
{
    public class Assignment
    {

        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(15)]
        public string Title { get; set; }

        [MinLength(3)]
        [MaxLength(15)]
        public string Description { get; set; }

        [Display(Name ="Submission Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime SubDate { get; set; }

        [Range(1,100)]
        [Display(Name="Oral Mark")]
        public int OralMark { get; set; }

        [Range(1, 100)]
        [Display(Name = "Total Mark")]
        public int TotalMark { get; set; }

        [MaxLength(15)]
        public string Course { get; set; }
    }
}