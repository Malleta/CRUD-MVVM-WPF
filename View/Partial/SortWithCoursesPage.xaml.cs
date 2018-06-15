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

namespace Mini_projekat_2___Entity_Framework_MVVM.View.Partial
{
    /// <summary>
    /// Interaction logic for SortWithCourses.xaml
    /// </summary>
    public partial class SortWithCourses : Page
    {
        public SortWithCourses()
        {
            InitializeComponent();
            CoursesListBox.ItemsSource = new AddPageViewModel().GetCourses();
        }

        private void SortCoursesButton_Click(object sender, RoutedEventArgs e)
        {
            //    foreach (Course course in CoursesListBox.SelectedItems)
            //    {
            //        Courses.Add(course);
            //    }
        }
    }
}
