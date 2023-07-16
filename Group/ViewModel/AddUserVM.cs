using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop01.DataContext;
using Desktop01.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Application;

namespace Desktop01
{
    public partial class AddUserVM : ObservableObject

    {
        //Observable objects
        [ObservableProperty]
        public string? firstname;

        [ObservableProperty]
        public string? lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string? dateofbirth;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public string? title;

        [ObservableProperty]
        public string? selectedImage;




#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public AddUserVM(Student student)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

            Firstname = student.FirstName;
            Lastname = student.LastName;
            Age = student.Age;
            Gpa = 4;
            Dateofbirth = student.DateOfBirth;
            SelectedImage = student.Image;

        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public AddUserVM()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            SelectedImage = "..\\Model\\Images\\NoPic.png";
        }

        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                SelectedImage = "..\\Model\\Images\\NoPic.png";
                MessageBox.Show("Image is successfuly uploded!", "successfull");
            }
        }






        public Student Student { get; private set; }
        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void Save()
        {
            if (Gpa < 0 || Gpa > 4)
            {
                MessageBox.Show("0.0 <= GPA <= 4.0", "Error");
                return;
            }
            if (Student == null)
            {
                Student = new Student()
                {
                    FirstName = Firstname,
                    LastName = Lastname,
                    Age = Age,
                    DateOfBirth = Dateofbirth,
                    Image = SelectedImage,
                    GPA = Gpa
                };
                using (var dataContext = new UserDataContext())
                {
                    dataContext.Students.Add(Student);
                    dataContext.SaveChanges();
                }
            }
            else
            {
                Student.FirstName = Firstname;
                Student.LastName = Lastname;
                Student.Age = Age;
                Student.GPA = Gpa;
                Student.Image = SelectedImage;
                Student.DateOfBirth = Dateofbirth;
                using (var dataContext = new UserDataContext())
                {
                    dataContext.Students.Add(Student);
                    dataContext.SaveChanges();
                }
            }

            if (Student.FirstName != null)
            {
                CloseAction();
            }
            Application.Current.MainWindow.Show();
        }

        [RelayCommand]
        public void Back()
        {
            var window = Application.Current.MainWindow;
            window.Show();
            Application.Current.MainWindow.Close();
        }
    }
}
