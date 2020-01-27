using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAMOSIN_991481359_LABS.Models
{
    public class Course
    {
        [Required(ErrorMessage = "Please Enter a Course Code")]
        public string courseCode { get; set; }
        [Required(ErrorMessage = "Please Enter the Course Name")]
        public string courseName { get; set; }
        [Required(ErrorMessage = "Please Enter the Enrolled Number")]
        public int enrolled { get; set; }
        [Required(ErrorMessage = "Please Enter the Credit Number")]
        public int creditNumber { get; set; }
    }
}
