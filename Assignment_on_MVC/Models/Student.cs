using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_on_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}