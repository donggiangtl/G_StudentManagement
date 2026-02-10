using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace G_StudentManagement.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDb") { }


        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}