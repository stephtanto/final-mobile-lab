

using Bootcamp2016.AmazingRace.Models;
using Bootcamp2016.AmazingRace.Services;
using System.Collections.Generic;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides a list of current clues for a specific race
    /// </summary>
    public class CluesViewModel : BaseScreen
    {
        private readonly IDataService _dataService;
        private readonly ISettingService _settings;
        public List<CluesItemViewModel> Clues { get; set; }

        public CluesViewModel()
        {
            DisplayName = "Clues";
            Clues = new List<CluesItemViewModel>() {
                new CluesItemViewModel() {
                    Title = "ALPHA"
                },
                new CluesItemViewModel() {
                    Title = "BETA"
                }
            };

        }

    }
}
