using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPMVC.Models
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(int id,string firstname, string lastname, string gender, int salary)
        {
            this.ID = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Gender = gender;
            this.Salary = salary;
        }
        [Key]
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        public int Salary { get; set; }
    }
}