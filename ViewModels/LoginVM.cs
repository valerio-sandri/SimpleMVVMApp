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
        public ICommand LoginCommand { get; }
        public ICommand LogoutCommand { get; }

        public LoginVM()
        {
            LoginCommand = new RelayCommand((param) => Login());
            LogoutCommand = new RelayCommand((param) => Logout());
        }


        private void Login()
        {
            if (User.GetInstance().isLoggedIn)
            {
                MessageBox.Show($"User already logged in, press logout before logging in.");
            }
            else
            {
                if (!string.IsNullOrEmpty(LoginCredentials.GetInstance().UserName))
                {
                    if (!string.IsNullOrEmpty(LoginCredentials.GetInstance().Password))
                    {
                        //TODO: try login!

                        if (User.GetInstance().Login(LoginCredentials.GetInstance().UserName, LoginCredentials.GetInstance().Password))
                        {
                            MessageBox.Show($"User {User.GetInstance().UserName} with Password {User.GetInstance().Password} logged in.");
                        }
                        else
                        {
                            MessageBox.Show($"User {User.GetInstance().UserName} with Password {User.GetInstance().Password} login failed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Password string is empty.");
                    }
                }
                else
                {
                    MessageBox.Show($"User string is empty.");
                }

            }
        }

        private void Logout()
        {
            if (User.GetInstance().isLoggedIn)
            {
                User.GetInstance().Logout();

                MessageBox.Show($"User {User.GetInstance().UserName} logged out.");
            }
            else
            {
                MessageBox.Show($"No user was logged in.");
            }
        }

        public string UserName
        {
            get => LoginCredentials.GetInstance().UserName;
            set
            {
                LoginCredentials.GetInstance().UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get => LoginCredentials.GetInstance().Password;
            set
            {
                LoginCredentials.GetInstance().Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

    }


}
