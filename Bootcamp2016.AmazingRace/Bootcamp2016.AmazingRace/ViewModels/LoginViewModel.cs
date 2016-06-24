using Caliburn.Micro;

using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Bootcamp2016.AmazingRace.Views;
using Caliburn.Micro.Xamarin.Forms;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides login functionality
    /// </summary>
    public class LoginViewModel : Screen
    {
        public INavigationService navigation { get; private set; }

        public string JoinCode { get; set; }

        public LoginViewModel(INavigationService navigation) {
            this.navigation = navigation;
            JoinCode = "Test";
        }

        public async void NextPageCommand() {
            await navigation.NavigateToViewModelAsync<TabbedViewModel>();
        }

        public void OnJoin()
        {
            //NotifyOfPropertyChange(() => JoinCode);

        }
    }
}
