using SimpleMVVMApp.Commands;
using SimpleMVVMApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SimpleMVVMApp.ViewModels
{
    internal class LoginVM : ViewModelBase
    {
        private User user;

        public ICommand LoginCommand { get; }
        public ICommand LogoutCommand { get; }

        public LoginVM()
        {
            user = new User();
            LoginCommand = new RelayCommand((param) => Login());
            LogoutCommand = new RelayCommand((param) => Logout());
        }


        private void Login()
        {
            if (user.isLoggedIn)
            {
                MessageBox.Show($"User already logged in, press logout before logging in.");
            }
            else
            {
                //TODO: check if can login
                user.isLoggedIn = true;
                MessageBox.Show($"User {user.UserName} with Password {user.Password} logged in.");
            }
        }

        private void Logout()
        {
            if (user.isLoggedIn)
            {
                user.isLoggedIn = false;
                MessageBox.Show($"User {user.UserName} logged out.");
            }
            else
            {
                MessageBox.Show($"No user was logged in.");
            }
        }

        public string UserName
        {
            get => user.UserName;
            set
            {
                user.UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get => user.Password;
            set
            {
                user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
    }


}
