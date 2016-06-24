using Caliburn.Micro;

using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Bootcamp2016.AmazingRace.Views;
using Caliburn.Micro.Xamarin.Forms;
using Xamarin.Forms;
using Bootcamp2016.AmazingRace.Services;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides login functionality
    /// </summary>
    public class LoginViewModel : Screen
    {
        private readonly IAuthenticationService _auth;

        public INavigationService navigation { get; private set; }

        public string JoinCode { get; set; }

        public LoginViewModel(INavigationService navigation, IAuthenticationService auth) {
            _auth = auth;
            this.navigation = navigation;
            JoinCode = "Test";
        }

        public async void NextPageCommand() {
            await navigation.NavigateToViewModelAsync<TabbedViewModel>();
        }

        public void OnJoin()
        {
            _auth.LoginAsync();
            //NotifyOfPropertyChange(() => JoinCode);

        }
    }
}
