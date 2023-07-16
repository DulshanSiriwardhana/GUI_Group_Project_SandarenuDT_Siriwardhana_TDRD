using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop01.DataContext;
using Desktop01.Model;
using Desktop01.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Application = System.Windows.Application;

namespace Desktop01.ViewModel
{
    public partial class AdminWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string name_;
        [ObservableProperty]
        public string password_;
        [ObservableProperty]
        public string id_;
        [ObservableProperty]
        public BitmapImage image;
        [ObservableProperty]
        public ObservableCollection<User> userscollection;
        [ObservableProperty]
        public User selectedUser;
        private int CurrentId;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public AdminWindowVM()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            LoadGrid();
            Image = new BitmapImage(new Uri("..\\Model\\Images\\NoPic.png", UriKind.Relative));
        }
        [RelayCommand]
        public void CreateUser()
        {
            if (Isfilled())
            {
                CurrentId = 0;
                foreach (var tmpuser in Userscollection)
                {
                    if (CurrentId + 1 == tmpuser.Id)
                    {
                        CurrentId++;
                        //MessageBox.Show((CurrentId + 1).ToString(), "Error");
                    }
                }
                User user = new User(++CurrentId, Name_, Password_);
                using (UserDataContext dataContext = new UserDataContext())
                {
                    dataContext.Users.Add(user);
                    dataContext.SaveChanges();
                    Userscollection.Add(user);
                }
            }
            else
            {
                MessageBox.Show("All the inputs are not filled!", "Error");
            }
        }
        [RelayCommand]
        public void DeleteUser()
        {
            if (SelectedUser != null)
            {
                string? name = SelectedUser.Name;
                Userscollection.Remove(SelectedUser);
                using (UserDataContext dataContext = new UserDataContext())
                {
                    try
                    {
                        dataContext.Users.Remove(SelectedUser);
                        dataContext.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("DataBase is not updated");
                    }

                }
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");

            }
            else
            {
                MessageBox.Show("Select a Student.", "Error");
            }
        }
        [RelayCommand]
        public void ModifyUser()
        {
            try
            {
                if (Id_ != null && int.Parse(Id_) > 1 && Isfilled())
                {
                    foreach (User user in Userscollection)
                    {
                        if (user.Id == int.Parse(Id_))
                        {
                            user.Name = Name_;
                            user.Password = Password_;
                            using (UserDataContext dataContext = new UserDataContext())
                            {
                                User tmpuser = dataContext.Users.Find(user.Id);
                                tmpuser.Name = Name_;
                                tmpuser.Password = Password_;
                                dataContext.SaveChanges();
                            }
                            return;
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        [RelayCommand]
        public void Back()
        {
            var window = new LoginWindow();
            window.Show();
            Application.Current.MainWindow.Close();
        }
        public void LoadGrid()
        {
            CurrentId = 0;
            Userscollection = new ObservableCollection<User>();
            using (UserDataContext dataContext = new UserDataContext())
            {
                foreach (var user in dataContext.Users)
                {
                    //user.Name = ("                  "+user.Name + "                  ").Substring(0,40);
                    Userscollection.Add(user);
                    CurrentId++;
                }
            }
        }
        public bool Isfilled()
        {
            if ((Name_ == null) || (Password_ == null))
            {
                return false;
            }
            return true;
        }
    }
}
