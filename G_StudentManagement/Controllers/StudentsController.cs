using G_StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace G_StudentManagement.Controllers
{
    public class StudentsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // Page
        public ActionResult ByClass()
        {
            ViewBag.Classes = new SelectList(db.Classes, "ClassId", "ClassName");
            return View();
        }

        // AJAX – DataTables
        [HttpGet]
        public ActionResult GetStudentsByClass(int classId)
        {
            var data = db.Students
                .Where(s => s.ClassId == classId)
                .Select(s => new
                {
                    s.StudentId,
                    s.FullName,
                    s.Age,
                    ClassName = s.Class.ClassName
                })
                .ToList();

            return Json(new { data = data }, JsonRequestBehavior.AllowGet);
        }

        // GET: Students
        public ActionResult Index()
        {
            var students = db.Students.Include(s => s.Class).ToList();
            return View(students);
        }
        public ActionResult Create()
        {
            ViewBag.ClassId = new SelectList(db.Classes, "ClassId", "ClassName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            ViewBag.ClassId = new SelectList(db.Classes, "ClassId", "ClassName", student.ClassId);
            return View(student);
        }
    }
}