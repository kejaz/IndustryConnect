using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Student
    {
        public Student()
        {
        }
        public Student(int id, string name)
        {
            this.StudentId = id;
            this.StudentName = name;
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
}