using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace travelAgency.HelpClasses
{
    class Route
    {
        public int Id { get; set; }
        public string Climate { get; set; }
        public string Country { get; set; }
        public string Hotel { get; set; }
        public int Duration { get; set; }
        public float Cost { get; set; }

        public Route(int id, string climate, string country, string hotel, int duration, float cost)
        {
            Id = id;
            Climate = climate;
            Country = country;
            Hotel = hotel;
            Duration = duration;
            Cost = cost;
        }
    }
}
