namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Clue details
    /// </summary>
    public class Clue
    {
        public string id { get; set; }
        public string description { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public int range { get; set; }
    }
}