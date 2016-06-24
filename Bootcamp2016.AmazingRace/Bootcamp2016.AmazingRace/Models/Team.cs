using System;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Team model object
    /// </summary>
    public class Team
    {
        public string id { get; set; }
        public string name { get; set; }
        public string imageUri { get; set; }
        public int rank { get; set; }
        public int points { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
    }
}