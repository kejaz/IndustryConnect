using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleTestApp.Models
{
    public class User
    {
        [Remote("IsNameExist","Home",ErrorMessage ="User name already in use")]


        [Required(ErrorMessage ="Name is Required")]
        [MaxLength(20, ErrorMessage = "Name cannot be longer than 20 characters.")]
        [MinLength(5, ErrorMessage = "Name should be at least 5 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range(18,45,ErrorMessage = "Enter age between 18 to 45")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }
    }
}