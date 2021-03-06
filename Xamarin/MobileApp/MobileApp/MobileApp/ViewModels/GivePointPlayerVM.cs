using MobileApp.Models;
using MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    [QueryProperty("Jeune", "jeune")]
    public class GivePointPlayerVM : BaseVM
    {
        GivePointPlayerService Service;
        public GivePointPlayerVM()
        {
            Service = new GivePointPlayerService();
            CreateGagnerOuPerdre = new Command(ExecuteCreateGagnerOuPerdre);
        }

        #region Property string => Jeune
        private string _jeune;
        public string Jeune 
        { 
            get { return _jeune; } 
            set 
            { 
                _jeune = Uri.UnescapeDataString(value);
                Criteres = Service.GetCritèrePoint(bool.Parse(Jeune));
                Players = Service.GetPlayers(bool.Parse(Jeune));
            } 
        }


        #endregion

        #region Property User => SelectUser
        private User _selectUser;
        public User SelectUser 
        { 
            get => _selectUser;
            set => SetProperty(ref _selectUser, value);
        }
        #endregion

        #region Property User => SelectCritere
        private CriterePoint _selectCritere;
        public CriterePoint SelectCritere
        {
            get => _selectCritere;
            set => SetProperty(ref _selectCritere, value);
        }
        #endregion

        #region Property ObservableCollection => Criteres
        private ObservableCollection<CriterePoint> _criteres;
        public ObservableCollection<CriterePoint> Criteres
        {
            get => _criteres;
            set => SetProperty(ref _criteres, value);
        }
        #endregion

        #region Property ObservableCollection => Players
        private ObservableCollection<User> _players;
        public ObservableCollection<User> Players
        {
            get => _players;
            set => SetProperty(ref _players, value);
        }
        #endregion

        #region ICommand => CreateGagnerOuPerdre
        public ICommand CreateGagnerOuPerdre { get; }

        private void ExecuteCreateGagnerOuPerdre()
        {
            if (Service.GivePointToAPlayerAsync(SelectUser, SelectCritere))
            {
                Display("Action effectuer", $"{SelectUser.Login} a reçu {SelectCritere.NombrePoint} point(s) pour : {SelectCritere.Description}", "OK");
            }
        }
        #endregion
    }
}
