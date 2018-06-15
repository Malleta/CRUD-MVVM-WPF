using Mini_projekat_2___Entity_Framework_MVVM.Model;
using Mini_projekat_2___Entity_Framework_MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mini_projekat_2___Entity_Framework_MVVM.View
{
    /// <summary>
    /// Interaction logic for ModifyPage.xaml
    /// </summary>
    public partial class ModifyPage : Page
    {
        ModifyPageViewModel modifyPageViewModel = new ModifyPageViewModel();
        Student student;

        public ModifyPage(int StudentId)
        {
            InitializeComponent();
            
            student = modifyPageViewModel.GetStudent(StudentId);

            sFirstName.Text = student.sFirstName;
            sLastName.Text = student.sLastName;
            Address1.Text = student.Address.Address1;
            City.Text = student.Address.City;
            Country.Text = student.Address.Country;
            CoursesListBox.ItemsSource = new AddPageViewModel().GetCourses();

            //Nije najpametnije resenje
            //foreach (Course course in student.Courses)
            //{
            //    CoursesListBox.SelectedItems.Add(CoursesListBox.Items.GetItemAt(course.CourseId-1));
            //}
        }

        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {
            var course = new List<Course>();
            foreach (Course item in CoursesListBox.SelectedItems)
            {
                course.Add(item);
            }

            modifyPageViewModel.UpdateStudent(new Student {
                StudentId = student.StudentId,
                sFirstName = sFirstName.Text,
                sLastName = sLastName.Text,
                Address = new Address
                {
                    AddressId = student.Address.AddressId,
                    Address1 = Address1.Text,
                    City = City.Text,
                    Country = Country.Text
                }
            }, course);
        }
    }
}
