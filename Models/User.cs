using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVMApp.Models
{
    internal class User
    {
        private bool _isLoggedIn;
        private string _userName;
        private string _password;
        private string _group;


        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }
        public string Group
        {
            get => _group;
            set => _group = value;
        }

        public bool isLoggedIn
        {
            get => _isLoggedIn;
            set => _isLoggedIn = value;            
        }

        public User()
        {
            _isLoggedIn = false;
            _userName = string.Empty;
            _password = string.Empty;
            _group = string.Empty;
        }
    }
}
