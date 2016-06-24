using Bootcamp2016.AmazingRace.Models;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Services.Imp
{
    public class DataService : IDataService
    {
        private IMobileServiceClient _client;
        public DataService(IMobileServiceClient client)
        {
            _client = client;
        }

        public async Task<Profile> GetProfileAsync()
        {
            var result = await _client.InvokeApiAsync<Profile>("profile", HttpMethod.Get, null);
            return result;
        }

        public async Task<Team> JoinTeamAsync(string teamCode)
        {
            var parameters = new Dictionary<string, string> { ["joinCode"] = teamCode };
            var path = "profile";
            var result = await _client.InvokeApiAsync<Team>(path, HttpMethod.Post, parameters);
            return result;  
        }

        public async Task<IEnumerable<Race>> GetRacesAsync()
        {
            var result = await _client.InvokeApiAsync<IEnumerable<Race>>("race", HttpMethod.Get, null);
            return result;
        }

        public async Task<Race> GetRaceAsync(string id)
        {
            var path = "race/" + id;
            var result = await _client.InvokeApiAsync<Race>(path, HttpMethod.Get, null);
            return result;
        }

        public async Task<List<Clue>> GetCluesAsync(string raceId)
        {
            var path = "race/" + raceId + "/clues";
            var result = await _client.InvokeApiAsync<List<Clue>>(path, HttpMethod.Get, null);
            return result;
        }

        public async Task<bool> PostClueResponse(string clueId, double lat, double lng, byte[] dataArray)
        {
            IDictionary<string, string> body = new Dictionary<string, string>();

            body.Add("clientid", clueId);
            body.Add("latitude", lat.ToString());
            body.Add("longitude", lng.ToString());
            body.Add("data", dataArray.ToString());

            var result = await _client.InvokeApiAsync<bool>("clue", HttpMethod.Post, body);
            return result;
        }

        //public async Task<bool> PostLocationUpdate(Location location)
        //{
        //    var result = await _client.InvokeApiAsync<Team>(path, HttpMethod.Post, null);
        //    return result;
        //}

        //public async Task<string> RegisterForPushNotifications(string regId)
        //{
        //    var result = await _client.InvokeApiAsync<Team>(path, HttpMethod.Post, null);
        //    return result;
        //}

        //public async Task<bool> UpdateDeviceInfoForPushNotifications(string regId, DeviceRegistration device)
        //{
        //    var result = await _client.InvokeApiAsync<Team>(path, HttpMethod.Post, null);
        //    return result;
        //}
    }
}
