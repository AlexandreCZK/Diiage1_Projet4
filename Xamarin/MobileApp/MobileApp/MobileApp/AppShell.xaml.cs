using MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(Constants.HOME_PAGE, typeof(MainView));
            Routing.RegisterRoute(Constants.GIVE_POINT_PAGE, typeof(GivePointPlayerView));
            Routing.RegisterRoute(Constants.SEE_POINT_PAGE, typeof(SeePointPlayerView));
        }

        //public ICommand LogoutCommand => new Command(ExecuteLogoutCommand);
        //public void ExecuteLogoutCommand()
        //{
        //    App.User = null;
        //    Current.Navigation.PushAsync(new LoginView());
        //}

        private void ExecuteLogoutCommand(object sender, EventArgs e)
        {
            App.User = null;
            Current.Navigation.PushAsync(new LoginView());
        }
    }
}