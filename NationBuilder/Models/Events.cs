using System;
using System.Collections.Generic;

namespace NationBuilder.Models
{
    public class Events
    {
        public List<string> disaster = new List<string>
        {
            "Tsunami",
            "Forest Fire",
            "Flood",
            "Earthquake"
        };

        public List<string> market = new List<string>
        {
            "Unemployment",
            "Overpopulation",
            "War"
        };

        public List<string> tech = new List<string>
        {
            "Military",
            "Automobiles",
            "Internet",
            "Social Media",
            "Cryptocurrency",
            "Space Exploration"
        };
                

    }
}
