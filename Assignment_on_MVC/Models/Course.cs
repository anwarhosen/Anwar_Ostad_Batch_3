using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_on_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
        public Course()
        {
            Students = new List<Student>();
        }
    }
}