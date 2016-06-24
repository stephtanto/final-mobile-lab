

using System.Collections.Generic;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides a list of leaders in order for a specific race
    /// </summary>
    public class LeaderViewModel : BaseScreen
    {
		public List<LeaderItemViewModel> Leads { get; set; }

		public LeaderViewModel() {
			DisplayName = "Leader";
			Leads = new List<LeaderItemViewModel>() {
				new LeaderItemViewModel() {
					Title = "ALPHA"
				},
				new LeaderItemViewModel() {
					Title = "BETA"
				}
			};
		}
    }
}
