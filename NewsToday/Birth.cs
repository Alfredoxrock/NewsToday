using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsToday
{
    class Birth
    {
        public string dOBDay, dOBMonth, dOBYear;

        public Birth(string dOBday_, string dOBMobnth, string dOBYear_)
        {
            dOBDay = dOBday_;
            dOBMonth = dOBMobnth;
            dOBYear = dOBYear_;
        }

        public Birth(string line)
        {
            string[] parts = line.Split(':');
            dOBDay = parts[0];
            dOBMonth = parts[1];
            dOBYear = parts[2];
        }

        public string serlialize()
        {
            return dOBDay + ":" + dOBMonth + ":" + dOBYear;
        }
    }
}
