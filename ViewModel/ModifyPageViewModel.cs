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
    class ModifyPageViewModel
    {
        public int UpdateStudent(Student student, List<Course> courses)
        {
            using (var db = new MiniDbContext())
            {
                var oldStudent = db.Students
                    .Include("Courses")
                    .Include("Address")
                    .SingleOrDefault(s => s.StudentId == student.StudentId);


                foreach (var item in oldStudent.Courses.ToList())
                {
                    oldStudent.Courses.Remove(item);
                }

                db.Entry(oldStudent).CurrentValues.SetValues(student);
                db.Entry(oldStudent.Address).CurrentValues.SetValues(student.Address);

                foreach (var item in courses)
                {
                    oldStudent.Courses.Add(item);
                }

                return db.SaveChanges();
            }
        }

        public Student GetStudent(int StudentId)
        {
            using(var db = new MiniDbContext())
            {
                return db.Students
                    .Include("Courses")
                    .Include("Address")
                    .Where(s => s.StudentId == StudentId)
                    .FirstOrDefault() as Student;
            }
        }
    }
}
