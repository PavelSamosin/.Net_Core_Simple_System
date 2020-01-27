using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SAMOSIN_991481359_LABS.Models;

namespace SAMOSIN_991481359_LABS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("HomePage");
        }

        [HttpGet]
        public ViewResult StudentForm()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CourseForm()
        {
            return View();
        }
        [HttpGet]
        public ViewResult HomePage()
        {
            return View();
        }
        [HttpGet]
        public ViewResult DropStudent(Student student)
        {
            Repository.DeleteResponses(student);
            return View("HomePage");
        }
        [HttpGet]
        public ViewResult DropCourse(Course course)
        {
            Repository.DeleteCourse(course);
            return View("HomePage");
        }

        [HttpPost]
        public ViewResult StudentForm(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponses(student);
                return View("Submitted");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ViewResult CourseForm(Course course)
        {
            if (ModelState.IsValid)
            {
                Repository.AddCourse(course);
                return View("Submitted");
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ViewResult Summary()
        {
            return View(Repository.Responses);
        }
        public ViewResult CourseSummary() 
        {
            return View(Repository.Courses);
        }
    }
}
