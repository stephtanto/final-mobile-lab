using Caliburn.Micro;

using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Bootcamp2016.AmazingRace.Views;
using Caliburn.Micro.Xamarin.Forms;
using Xamarin.Forms;
using Bootcamp2016.AmazingRace.Services.Imp;
using Bootcamp2016.AmazingRace.Models;
using Bootcamp2016.AmazingRace.Services;
using System.Collections.Generic;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides login functionality
    /// </summary>
    public class LoginViewModel : Screen
    {
        private readonly IDataService _dataService;
        private readonly IAuthenticationService _auth;
        private readonly ISettingsService _settings;

        public INavigationService navigation { get; private set; }

        public string JoinCode { get; set; }

        public LoginViewModel(INavigationService navigation, IDataService dataService, IAuthenticationService auth, ISettingsService settings) {
            this.navigation = navigation;
            _dataService = dataService;
            _auth = auth;
            _settings = settings;
            JoinCode = "seedless";
        }

        public async void NextPageCommand() {
            await navigation.NavigateToViewModelAsync<TabbedViewModel>();
        }

        public async void Login()
        {
            bool isLogged = await _auth.IsLoggedInAsync();
            if (!isLogged)
            {
               await _auth.LoginAsync();
            }
        }

        public async void OnJoin()
        {
            //Team team = await _dataService.JoinTeamAsync(JoinCode);
            //_settings.TeamId = team.id;

            IEnumerable<Race> races = await _dataService.GetRacesAsync();
            foreach (Race race in races)
            {
                _settings.RaceId = race.id;
            }
            _settings.TeamId = "0cad0a44-f804-43de-b696-29f54f764993";
            //_settings.RaceId = "42927fab-04db-462b-b0f9-9a8798e00dff";
            return;
        }
    }
}
