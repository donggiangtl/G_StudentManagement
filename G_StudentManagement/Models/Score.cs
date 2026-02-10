using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_StudentManagement.Models
{
    public class Score
    {
        public int ScoreId { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public int SubjectId { get; set; }
        [Required]
        public int TeacherId { get; set; }   // NEW

        [Range(0, 10)]
        public decimal ScoreValue { get; set; }

        public DateTime? ExamDate { get; set; }

        // Navigation properties
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
        [ForeignKey("TeacherId")]          // NEW
        public virtual Teacher Teacher { get; set; } // NEW
    }
}