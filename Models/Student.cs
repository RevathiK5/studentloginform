using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LOGINFORM.Models
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Course { get; set; }
        [Required]
        public string FirstName { get; set; }
    }
}