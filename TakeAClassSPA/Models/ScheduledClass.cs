using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.TakeAClassSPA.Models
{
    public class ScheduledClass
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public DateTime ClassDate { get; set; }
        public string Instructor { get; set; }
        public string ClassDescription { get; set; }
        public List<Student> Students { get; set; }
    }

    public class Student
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}