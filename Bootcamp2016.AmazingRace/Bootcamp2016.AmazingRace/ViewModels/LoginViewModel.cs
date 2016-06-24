

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
    public class LoginViewModel : BaseScreen
    {
		public INavigationService navigation { get; private set; }

		public LoginViewModel(INavigationService navigation) {
			this.navigation = navigation;
		}

		public async void NextPageCommand() {
			await navigation.NavigateToViewModelAsync<TabbedViewModel>();
		}
	}
}
