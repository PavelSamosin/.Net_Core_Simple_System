using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAMOSIN_991481359_LABS.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Enter Your First Name")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Last Name")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "Please Select A Course")]
        public string selectedCourse { get; set; }
        [Required(ErrorMessage = "Please Enter Your Student Number")]
        public int studentNum { get; set; }
    }
}
