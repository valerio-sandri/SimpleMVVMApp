namespace SimpleMVVMApp.ViewModels
{
    internal class LoginCredentials
    {
        private string _username;
        private string _password;
        private static LoginCredentials _instance = null;

        public string UserName
        {
            get => _username;
            set => _username = value;
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }
        
        private LoginCredentials()
        {
            _username = string.Empty;
            _password = string.Empty;
        }

        public static LoginCredentials GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoginCredentials();
            }
            return _instance;
        }

    }
}
