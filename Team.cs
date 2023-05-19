using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football2
{
    internal class Team
    {
        

        public Team(Coach coach, Player[] players)
        {
            if(players.Length < 10 || players.Length > 23)
            {
                throw new ArgumentException();
            }
            Console.WriteLine("Average age of the players " + Average(players));
        }
        public double Average(Player[] players)
        {
            int average = 0;

            foreach (Player item in players)
            {
                average += item.Age;
                
            }
            return average / players.Length;
        }
    }
}
