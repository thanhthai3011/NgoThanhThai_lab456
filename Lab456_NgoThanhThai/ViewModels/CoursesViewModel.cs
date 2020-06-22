using Lab456_NgoThanhThai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab456_NgoThanhThai.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpCommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}