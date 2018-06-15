using Mini_projekat_2___Entity_Framework_MVVM.Model;
using Mini_projekat_2___Entity_Framework_MVVM.ViewModel;
using Mini_projekat_2___Entity_Framework_MVVM.View.Partial;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace Mini_projekat_2___Entity_Framework_MVVM.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        MainPageViewModel mainPageViewModel = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            ListBoxSort.SelectedIndex = 0;
            StudentsDataGrid.ItemsSource = mainPageViewModel.GetStudents();
            CoursesListBox.ItemsSource = new AddPageViewModel().GetCourses();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var host = new Window();
            host.Content = new AddPage();
            host.ShowDialog();
        }

        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {
            Student student = (Student)StudentsDataGrid.SelectedItem;
            if (student != null)
            {
                var host = new Window();
                host.Content = new ModifyPage(student.StudentId);
                host.ShowDialog();
            } else
            {
                MessageBox.Show("Pick an item from a list");
            }
        }

        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            StudentsDataGrid.ItemsSource = mainPageViewModel.GetStudents();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Student student = (Student)StudentsDataGrid.SelectedItem;

            if (student != null)
            {
                DeletedPageViewModel deletedPageViewModel = new DeletedPageViewModel();
                var deletedStudentStatus = deletedPageViewModel.DeleteStudent(student.StudentId);
                MessageBox.Show("Student is deleted successfully!");
                StudentsDataGrid.ItemsSource = mainPageViewModel.GetStudents();
            } else
            {
                MessageBox.Show("Student is deleted unsuccessfully!");
            }
        }

        private void ListBoxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StudentsDataGrid.ItemsSource = mainPageViewModel.GetStudentsSorted(ListBoxSort.Text);
        }

        //Radi se
        private void CoursesSortButton_Click(object sender, RoutedEventArgs e)
        {
            var host = new Window();
            host.Content = new SortWithCourses();
            host.ShowDialog();

        }

        private void SortWithCoursesButton_Click(object sender, RoutedEventArgs e)
        {
            var Courses = new List<Course>();

            foreach (Course course in CoursesListBox.SelectedItems)
            {
                Courses.Add(course);
            }

            foreach (var item in mainPageViewModel.SortStudentsWithCourses(Courses))
            {
                StudentsDataGrid.ItemsSource = item.Students;
            }    
            
        }
    }
}
