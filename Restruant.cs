using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class Restruant
    {
        private List<string> Restruants { get; } = new List<string> { "Chick Fil A", "Chipotle", "Subway", "McDonald's" };
        public string Name { get; set; }

        public Restruant()
        {
            var random = new Random();
            int index = random.Next(Restruants.Count);
            Name = Restruants[index];
        }
    }
}
