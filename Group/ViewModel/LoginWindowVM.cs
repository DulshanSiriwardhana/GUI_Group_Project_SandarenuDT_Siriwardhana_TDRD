using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop01.DataContext;
using Desktop01.Model;
using Desktop01.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Desktop01.ViewModel
{
    public partial class LoginWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string? userName_;
        [ObservableProperty]
        public string? password__;

        [RelayCommand]
        private void Login()
        {
            if(UserName_ == "Admin" && Password__ == "1234")
            {
                var window = new AdminWindow();
                window.Show();
                Application.Current.MainWindow.Close();
            }
            else if(UserName_ !="Admin")
            {
                using (var dataContext = new UserDataContext())
                {
                    foreach (var user in dataContext.Users)
                    {
                        if(user.Name== UserName_ && user.Password==Password__)
                        {
                            var window = new MainWindow();
                            window.Show();
                            Application.Current.MainWindow.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No user found!", "Error");
            }
        }

    }
}
