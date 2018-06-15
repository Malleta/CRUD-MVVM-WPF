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
    class DeletedPageViewModel
    {
        public int DeleteStudent(int StudentId)
        {
            using (var db = new MiniDbContext())
            {
                Student student = db.Students.Where(s => s.StudentId == StudentId)
                    .Include("Address")
                    .SingleOrDefault();

                db.Students.Remove(student);
                //db.Entry(student).State = EntityState.Deleted;

                return db.SaveChanges();
            }
        }
    }
}
