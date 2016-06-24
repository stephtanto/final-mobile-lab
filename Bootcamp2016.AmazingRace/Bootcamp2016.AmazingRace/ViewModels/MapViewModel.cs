

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Shows location of a clue
    /// </summary>
    public class MapViewModel : BaseScreen
    {
        public MapViewModel()
        {
            var map = new Map(
            MapSpan.FromCenterAndRadius(
            new Position(37, -122), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
        }
    }
    }
}
