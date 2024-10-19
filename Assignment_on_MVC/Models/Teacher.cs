using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_on_MVC.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public List<Course> Courses { get; set; }
        public Teacher() 
        {
            Courses=new List<Course>();
        }
    }
}