﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.Models
{
    /// <summary>
    /// Location object (used when uploading geolocation to server)
    /// </summary>
    public class Location
    {
        public string raceId { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}