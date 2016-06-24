using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Represents the response information received from the server when submitting a clue response
    /// </summary>
    public class PostClueResponse
    {
        public string id { get; set; }
        public string clueId { get; set; }
        public string raceId { get; set; }
        public string teamId { get; set; }
        public string userId { get; set; }
        public string data { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string imageUri { get; set; }
        public string containerName { get; set; }
        public string resourceName { get; set; }
        public string sasQueryString { get; set; }

    }
}
