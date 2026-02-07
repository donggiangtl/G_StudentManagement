using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace G_StudentManagement.Models
{
    public class Class
    {
        public int ClassId { get; set; }


        [Required]
        public string ClassName { get; set; }


        public virtual ICollection<Student> Students { get; set; }
    }
}