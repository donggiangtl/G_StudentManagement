using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_StudentManagement.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Email { get; set; }

        public DateTime? HireDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}