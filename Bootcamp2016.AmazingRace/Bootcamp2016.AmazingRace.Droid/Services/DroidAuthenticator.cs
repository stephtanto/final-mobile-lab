using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Bootcamp2016.AmazingRace.Services;
using Microsoft.WindowsAzure.MobileServices;
using Android.Gms.Auth.Api.SignIn;
using Android.Gms.Common.Apis;
using Android.Gms.Common;
using Xamarin.Forms;

namespace Bootcamp2016.AmazingRace.Droid.Services
{
    public class DroidAuthenticator : IPlatformAuthenticator
    {
        private readonly IMobileServiceClient _client;

        public DroidAuthenticator(IMobileServiceClient client)
        {
            _client = client;
        }

        public async Task<MobileServiceUser> Authenticate(MobileServiceAuthenticationProvider provider)
        {
            MobileServiceUser user = await _client.LoginAsync(Forms.Context, provider);
            return user;
        }
    }
}