using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class MainVM : BaseVM
    {
        public MainVM()
        {
            GoGivePoint = new Command(ExecuteGoGivePoint);
            GoGivePointSenior = new Command(ExecuteGoGivePointSenior);
            GoSeePoint = new Command(ExecuteGoSeePoint);
            if (App.User != null)
            {
                Username = "Bienvenue sur l'application AS SAGY " + App.User.Login.ToUpper();
                EstFormateur = App.User.EstFormateur;
            }
        }
        #region Property string => username
        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }
        #endregion

        #region Property bool => estFormateur
        private bool _estFormateur;
        public bool EstFormateur
        {
            get => _estFormateur;
            set => SetProperty(ref _estFormateur, value);
        }
        #endregion

        #region Property bool => estPasFormateur
        public bool EstPasFormateur
        {
            get => !_estFormateur;
        }
        #endregion

        #region ICommand => GoGivePoint
        public ICommand GoGivePoint { get; }
        private void ExecuteGoGivePoint()
        {
            Shell.Current.GoToAsync($"{Constants.GIVE_POINT_PAGE}?jeune={true}");
        }
        #endregion

        #region ICommand => GoGivePointSenior
        public ICommand GoGivePointSenior { get; }
        private void ExecuteGoGivePointSenior()
        {
            Shell.Current.GoToAsync($"{Constants.GIVE_POINT_PAGE}?jeune={false}");
        }
        #endregion

        #region ICommand => GoSeePoint
        public ICommand GoSeePoint { get; }
        private void ExecuteGoSeePoint()
        {
            Shell.Current.GoToAsync("//main/" + Constants.SEE_POINT_PAGE);
        }
        #endregion
    }
}
