﻿using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Bootcamp2016.AmazingRace.ViewModels;
using Xamarin.Forms;
using Bootcamp2016.AmazingRace.Services;
using Bootcamp2016.AmazingRace.Views;
using Microsoft.WindowsAzure.MobileServices;

namespace Bootcamp2016.AmazingRace
{
    public class App : FormsApplication
    {
        //DEV
        private static string MobileServicesUri = "https://infusionamazingrace.azure-mobile.net/";
        private static string MobileServicesAppKey = "XlYlBNtwuFzFROAbFpblbBQEPmdPJg64";

        ////PROD
        //public static string MobileServicesUri = "https://infusionamazingrace.azure-mobile.net/";
        //public static string MobileServicesAppKey = "XlYlBNtwuFzFROAbFpblbBQEPmdPJg64";

        private readonly SimpleContainer container;

        public App(SimpleContainer container)
        {
            this.container = container;

            IMobileServiceClient client = new MobileServiceClient(MobileServicesUri, MobileServicesAppKey);

            container
                .PerRequest<DetailViewModel>()
                .PerRequest<LoginViewModel>()
                .PerRequest<BaseViewModel>()
                .PerRequest<CluesViewModel>()
                .PerRequest<DummyViewModel>()
                .PerRequest<LeaderViewModel>()
                .PerRequest<MapViewModel>()
                .PerRequest<TabbedViewModel>()
                .Instance<IMobileServiceClient>(client)
                .Singleton<ISettingsService,SettingsService>()
                .Singleton<IAuthenticationService,AuthenticationService>()
                ;

            DisplayRootView<TabbedView>();
        }
        
        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
