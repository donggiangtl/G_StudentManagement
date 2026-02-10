using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace G_StudentManagement.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string SubjectName { get; set; }

        public int Credits { get; set; }
    }
}