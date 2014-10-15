using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingletonExample.Models
{
    public class AddTeacherVM
    {
        public List<Teacher> TeacherVM { get; set; }
        public Course CourseVM { get; set; }
    }

}