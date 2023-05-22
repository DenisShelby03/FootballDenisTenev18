using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDenisT18
{
    public class Team
    {
        public string Name { get; set; }   
        public Coach Coach { get; set; }
        public List<Football_player> Players { get; set; } = new List<Football_player>();
        public double AveragePlayerAge
        {
            get
            {
                int totalAge = 0;
                foreach (var player in Players)
                {
                    totalAge += player.Age;
                }
                return (double)totalAge / Players.Count;
            }
        }
    }
}

