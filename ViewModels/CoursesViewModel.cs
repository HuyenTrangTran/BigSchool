using lab3_trang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3_trang.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}