using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Device Registration (used for registering push notifications with server)
    /// </summary>
    public class DeviceRegistration
    {
        public string platform { get; set; }
        public string handle { get; set; }
        public List<string> tags { get; set; }
    }
}
