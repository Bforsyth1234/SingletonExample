using SingletonExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingletonExample.Controllers
{
    public class HomeController : Controller
    {
        InMemoryData data = InMemoryData.Instance;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student()
        {

            return View(data.Student);
        }

        public ActionResult Teacher()
        {



            return View(data.Teachers);
        }
        public ActionResult Course()
        {


            return View(data.Courses);
        }
        public ActionResult CourseDetail(int ID)
        {
            Course model = new Course();
            foreach (Course Unicorns in data.Courses )
            {
                if (Unicorns.ID == ID)
                {
                    model = Unicorns;
                    break;
                }
            };
            return View(model);
        }
    [HttpPost]
        public ActionResult AddTeacher(int ID)
        {
            return View();
        }
        public ActionResult AddTeacher(int ID)
    {
        AddTeacherVM model = new AddTeacherVM();
        model.TeacherVM = data.Teachers;
        model.CourseVM = data.Courses.Where(x => x.ID == ID).FirstOrDefault();
        return View(model);
    }
    }

}