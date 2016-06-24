using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Represents payload information when submitting a clue response to the server
    /// </summary>
    public class PostClueRequest
    {
        public string clueId { get; set; }
        public string data { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
