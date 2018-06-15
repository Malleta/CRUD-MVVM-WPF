using Mini_projekat_2___Entity_Framework_MVVM.Data;
using Mini_projekat_2___Entity_Framework_MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_projekat_2___Entity_Framework_MVVM.ViewModel
{
    class MainPageViewModel
    {
        public List<Student> GetStudents()
        {
            using(var db = new MiniDbContext())
            {
                return db.Students
                    .Include("Courses")
                    .Include("Address").ToList();
            }
        }

        public List<Student> GetStudentsSorted(string sortbytype)
        {
            using (var db = new MiniDbContext())
            {
                try
                {
                    switch (sortbytype)
                    {
                        case ("First Name - Ascending"):
                            return db.Students
                                .Include("Courses")
                                .Include("Address")
                                .OrderBy(s => s.sFirstName).ToList();
                        case ("First Name - Descending"):
                            return db.Students
                                .Include("Courses")
                                .Include("Address")
                                .OrderByDescending(s => s.sFirstName).ToList();
                        case ("Last Name - Ascending"):
                            return db.Students
                                .Include("Courses")
                                .Include("Address")
                                .OrderBy(s => s.sLastName).ToList();
                        case ("Last Name - Descending"):
                            return db.Students
                                .Include("Courses")
                                .Include("Address")
                                .OrderByDescending(s => s.sLastName).ToList();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return null;
            }
        }

        public List<Course> SortStudentsWithCourses(List<Course> courses)
        {
            var Courses = new List<Course>();
            using (var db = new MiniDbContext())
            {
                Courses = db.Courses
                    .Include("Students").ToList();
            }

            var SortedCourses = new List<Course>();
            foreach (var course in courses)
            {
                foreach (var coursedb in Courses)
                {
                    if(course.CourseId == coursedb.CourseId)
                    {
                        SortedCourses.Add(coursedb);
                    }
                }
            }
            return SortedCourses;
        }
    }
}
