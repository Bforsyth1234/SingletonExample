using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingletonExample.Models
{
    public abstract class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }
    }
    public class Student : Person
    {
        public GradeLevel Level { get; set; }
    }
    public class Teacher : Person
    {
        public bool IsCertified { get; set; }
        public string DoctorateCollege { get; set; }
    }
    public class Course
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public enum GradeLevel
    {
        Freshman,
        Sophmore,
        Junior,
        Senior
    }
    public class InMemoryData
    {
        private static InMemoryData _instance;

        private static InMemoryData CreateNewInMemoryData()
        {
          return new InMemoryData()
            {

            Courses = new List<Course>()
            {
                new Course {ID = 100, Code = "Calc1", Title = "Calculius One", Description = "Really haard math"},
                new Course {ID = 101, Code = "Eng1", Title = "English", Description = "Learn to read"},
                new Course {ID = 102, Code = "Lat2", Title = "Latin", Description = "Learn a language no one uses"}
            },
            Student = new List<Student>()
            {
                new Student {FirstName = "Brooks", LastName = "Forsyth", Level = GradeLevel.Senior, ID = 123, Courses= new List<Course>()},
                new Student {FirstName = "Robin", LastName = "Canada", Level = GradeLevel.Senior, ID = 1234, Courses= new List<Course>()},
                new Student {FirstName = "Chris", LastName = "Griffin", Level = GradeLevel.Freshman, ID = 124, Courses= new List<Course>()},
            },
            Teachers = new List<Teacher>()
            {
                new Teacher {FirstName = "Barrack", LastName = "Obama", ID = 1, IsCertified = false, DoctorateCollege = "Harvard", Courses= new List<Course>()},
                new Teacher {FirstName = "Dog", LastName = "The Bounty Hunter", ID = 2, IsCertified = true, DoctorateCollege = "School of Hard Knocks", Courses= new List<Course>() },
                new Teacher {FirstName = "Jesus", LastName = "Christ", ID = 3, IsCertified = true, DoctorateCollege = "Notre Dame", Courses= new List<Course>() }
            }
         };
        }
        public static InMemoryData Instance
        {
            get
            {
                return _instance ?? (_instance = CreateNewInMemoryData());
            }
        }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Student { get; set; }
        public List<Course> Courses { get; set; }

        private InMemoryData()
        {

        }
    }
}