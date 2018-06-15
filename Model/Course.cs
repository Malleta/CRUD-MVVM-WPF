using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_projekat_2___Entity_Framework_MVVM.Model
{
    class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }

        public int CourseId { get; set; }

        public string cName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
