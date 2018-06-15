using Mini_projekat_2___Entity_Framework_MVVM.Data;
using Mini_projekat_2___Entity_Framework_MVVM.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_projekat_2___Entity_Framework_MVVM.ViewModel
{
    class AddPageViewModel
    {
        public List<Course> GetCourses()
        {
            using(var db = new MiniDbContext())
            {
               return db.Courses.Select(c => c).ToList();
            }
        }

        public int AddStudent(Student student, List<Course> courses )
        {
            using(var db = new MiniDbContext())
            {
                student.Courses = courses;
                db.Students.Add(student);

                //Ne dodaje child tabeli objekte, vec ih samo vezuje za parenta.
                foreach (Course course in courses)
                {
                    db.Entry(course).State = EntityState.Unchanged;
                }

                return db.SaveChanges();
            }
        }
    }
}
