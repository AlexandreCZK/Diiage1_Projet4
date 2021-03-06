using MobileApp.Services;
using MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class LoginVM : BaseVM
    {
        private readonly LoginService _loginService;

        public LoginVM()
        {
            _loginService = new LoginService();
            LoginCommand = new Command(ExecuteLoginCommand);
        }

        #region Property string => username
        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }
        #endregion

        #region Property string => password 
        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
        #endregion

        #region ICommand => LoginCommand
        public ICommand LoginCommand { get; }
        private async void ExecuteLoginCommand()
        {
            if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
            {
                Display("Login", "Enter an username and a password", "OK");
                return;
            }

            if (await _loginService.LoginAsync(_username, _password))
            {
                GoHome();
            }
            else
            {
                Display("Login", "Incorrect username or password", "OK");
                return;
            }
        }
        #endregion

        protected void GoHome()
        {
            //Shell.Current.GoToAsync("///main/");
            Shell.Current.GoToAsync("///main/" + Constants.HOME_PAGE);
        }
    }
}
