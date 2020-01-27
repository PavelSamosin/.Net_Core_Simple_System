using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAMOSIN_991481359_LABS.Models
{
    public class Repository
    {
        private static List<Student> responses = new List<Student>();
        private static List<Course> courses = new List<Course>();
        public static IEnumerable<Student> Responses
        {
            get
            {
                return responses;
            }
        }
        public static IEnumerable<Course> Courses
        {
            get
            {
                return courses;
            }
        }

        public static void AddResponses(Student response)
        {
            responses.Add(response);
        }
        public static void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public static void DeleteResponses(Student response)
        {
            responses.Remove(response);
        }
        public static void DeleteCourse(Course course)
        {
            courses.Remove(course);
        }
    }
}
