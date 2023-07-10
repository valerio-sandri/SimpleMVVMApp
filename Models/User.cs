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
        private static User _instance = null;


        public string UserName
        {
            get => _userName;
        }
        public string Password
        {
            get => _password;
        }
        public string Group
        {
            get => _group;
        }

        public bool isLoggedIn
        {
            get => _isLoggedIn;       
        }

        private User()
        {
            _isLoggedIn = false;
            _userName = string.Empty;
            _password = string.Empty;
            _group = string.Empty;
        }

        public static User GetInstance()
        {
            if(_instance==null)
                _instance = new User();
            return _instance;
        }

        //TODO: implement a method that performs login
        public bool Login(string userName, string password)
        {
            bool loginSuccess = false;
            //Add logic
            this._userName = userName;
            this._password = password;

            return loginSuccess;
        }

        public bool Logout()
        {
            bool logoutSuccess = false;
            //Add logic
            this._userName = string.Empty;
            this._password = string.Empty;
            this._group = string.Empty;
            this._isLoggedIn = false;


            return logoutSuccess;
        }

    }
}
