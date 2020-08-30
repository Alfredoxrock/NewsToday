using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsToday
{
    class Location
    {
        public string country, state, city;

        public Location(string country_, string state_, string city_)
        {
            country = country_;
            state = state_;
            city = city_;
        }

        public Location(string line)
        {
            string[] parts = line.Split('~');
            country = parts[0];
            state = parts[1];
            city = parts[2];
        }

        public string serialize()
        {
            return country + "~" + state + "~" + city;
        }
    }
}
