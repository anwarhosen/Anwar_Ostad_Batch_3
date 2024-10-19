using Assignment_on_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_on_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var teacher1 = new Teacher { Id = 1, TeacherName = "Protik Bhai" };
            var teacher2 = new Teacher { Id = 2, TeacherName = "Ehsan Bhai" };

            var course1 = new Course { Id = 1, CourseName = "Mathematics", Teacher = teacher1 };
            var course2 = new Course { Id = 2, CourseName = "Physics", Teacher = teacher2 };

            var students = new List<Student>
            {
                new Student { Id = 1, StudentName = "Md Anwar Hosen", Course = course1 },
                new Student { Id = 2, StudentName = "Ibrahim Khalil", Course = course2 },
                new Student { Id = 3, StudentName = "Lipi", Course = course1 },
                new Student { Id = 4, StudentName = "Nur Hossain", Course = course2 },
                new Student { Id = 5, StudentName = "Tajmul Islam", Course = course1 },
                new Student { Id = 6, StudentName = "Rozina", Course = course2 },
            };

            return View(students);
        }
    }
}