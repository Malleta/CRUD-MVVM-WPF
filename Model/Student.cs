using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_projekat_2___Entity_Framework_MVVM.Model
{
    class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
        }

        public int StudentId { get; set; }

        public string sFirstName { get; set; }

        public string sLastName { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
