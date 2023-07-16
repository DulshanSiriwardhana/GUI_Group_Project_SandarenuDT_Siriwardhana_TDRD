using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop01.DataContext;
using Desktop01.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Desktop01.ViewModel
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<User> users;
        [ObservableProperty]
        public Student selectedStudent;
        [ObservableProperty]
        private ObservableCollection<Student> studentCollection;

        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }


        [RelayCommand]
        public void message()
        {

            MessageBox.Show($"{SelectedStudent.FirstName}'s GPA value must be inbetween 0 and 4.", "Error");
        }

        [RelayCommand]
        public void AddStudent()
        {
            var tempstudent = new AddUserVM();
            tempstudent.Title = "Add User";
            AddUserWindow window = new AddUserWindow(tempstudent);
            window.ShowDialog();

            try
            {
                StudentCollection.Add(tempstudent.Student);

            }
            catch
            {
                MessageBox.Show("Add student window is closed unexpectedly!");
            }

        }

        [RelayCommand]
        public void Delete()
        {
            if (SelectedStudent != null)
            {
                string? name = SelectedStudent.FirstName;
                StudentCollection.Remove(SelectedStudent);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");

            }
            else
            {
                MessageBox.Show("Select a Student.", "Error");
            }
        }
        [RelayCommand]
        public void EditStudent()
        {
            if (SelectedStudent != null)
            {
                var tempstudent = new AddUserVM(SelectedStudent);
                tempstudent.Title = "Edit User";
                var window = new AddUserWindow(tempstudent);

                window.ShowDialog();

                try
                {
                    int index = StudentCollection.IndexOf(SelectedStudent);
                    if (tempstudent.Student != null)
                    {
                        StudentCollection.RemoveAt(index);
                        StudentCollection.Insert(index, tempstudent.Student);
                    }
                }
                catch
                {
                    MessageBox.Show("Edit window is closed");
                }



            }
            else
            {
                MessageBox.Show("Select a student to edit", "Warning!");
            }
        }
        [RelayCommand]
        public void Exit()
        {
            Application.Current.Shutdown();
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public MainWindowVM()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            StudentCollection = new ObservableCollection<Student>();
            using (var dataContext = new UserDataContext())
            {
                foreach (var student in dataContext.Students)
                {
                    StudentCollection.Add(student);
                    //MessageBox.Show(student.FirstName);
                }
            }

        }
    }
}
