using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using App.TakeAClassSPA.Models;

namespace App.TakeAClassSPA.Controllers
{
    public class ScheduledClassController : ApiController
    {
        // GET: api/ScheduledClass
        public IEnumerable<ScheduledClass> Get()
        {
            var classes = LoadData();
            return classes;
        }

        // GET: api/ScheduledClass/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ScheduledClass
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ScheduledClass/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ScheduledClass/5
        public void Delete(int id)
        {
        }

        private List<ScheduledClass> LoadData()
        {
            var classes = new List<ScheduledClass>();
            var scheduledClass = new ScheduledClass();
            scheduledClass.ClassID = 1;
            scheduledClass.ClassName = "Class 1";
            scheduledClass.ClassDate = Convert.ToDateTime("10/1/2014 10:00:00 AM");
            scheduledClass.ClassDescription = "This is class 1.";
            var students = new List<Student>();
            var student1 = new Student();
            student1.Email = "student1@asdf.com";
            student1.FirstName = "John";
            student1.LastName = "Doe";
            var student2 = new Student();
            student2.Email = "student2@qwer.com";
            student2.FirstName = "Sally";
            student2.LastName = "Smith";
            students.Add(student1);
            students.Add(student2);
            scheduledClass.Students = students;
            classes.Add(scheduledClass);
            return classes;
        }
    }
}
