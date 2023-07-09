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

        public LoginVM()
        {
            user = new User();
            LoginCommand = new RelayCommand((param) => LoggedIn(param));
        }

        private void LoggedIn(object param)
        {
            MessageBox.Show($"User {param} logged in.");
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
