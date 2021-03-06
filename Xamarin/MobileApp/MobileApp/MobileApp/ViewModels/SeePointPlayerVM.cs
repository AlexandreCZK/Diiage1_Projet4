using MobileApp.Models;
using MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobileApp.ViewModels
{
    public class SeePointPlayerVM : BaseVM
    {
        public SeePointPlayerVM()
        {
            SeePointPlayerService service = new SeePointPlayerService();
            PointsPlayer = new ObservableCollection<GagnerOuPerdre>();

            PointsPlayer = service.GetGagnerOuPerdre(App.User);
            CalculerTotalPoint();
        }

        #region Property ObservableCollection => PointsPlayer
        private ObservableCollection<GagnerOuPerdre> _pointsPlayer;
        public ObservableCollection<GagnerOuPerdre> PointsPlayer
        {
            get => _pointsPlayer;
            set => SetProperty(ref _pointsPlayer, value);
        }
        #endregion

        #region Property int => TotalPointsPlayer
        private int _totalPointsPlayer;
        public int TotalPointsPlayer
        {
            get => _totalPointsPlayer;
            set => SetProperty(ref _totalPointsPlayer, value);
        }
        #endregion

        private void CalculerTotalPoint()
        {
            TotalPointsPlayer = 500;
            foreach (var item in PointsPlayer)
            {
                TotalPointsPlayer += item.NbPoint;
            }
        }
    }
}
