using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_StudentManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }


        [Required]
        public string FullName { get; set; }


        public int Age { get; set; }


        [ForeignKey("Class")]
        public int ClassId { get; set; }


        public virtual Class Class { get; set; }
    }
}