using Caliburn.Micro;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Provides login functionality
    /// </summary>
    public class LoginViewModel : Screen
    {

        public LoginViewModel()
        {
            JoinCode = "Test";
        }
        public string JoinCode { get; set; }

        public void OnJoin()
        {
            //NotifyOfPropertyChange(() => JoinCode);

        }
    }


}
