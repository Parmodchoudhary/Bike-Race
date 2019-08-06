using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Race.Classes
{
    class Bet: Bike
    {
        public int amount { get; set; }
        public string biker { get; set; }
        public Guy guy { get; set; }
        public int odds { get; set; }
        public int dbOdds { get; set; }

        public string GetDescription()
        {
            if (amount == 0)
            {
                return guy.name + " hasn't placed a bet";
            }
            else
            {
                return guy.name + " placed a bet of $" + amount + " on " + biker;
            }
        }

        public int Payout(string winner)
        {
            if (winner == biker)
            {
                return amount * odds;
            }
            else
            {
                return (0 - amount);
            }
        }
    }
}
