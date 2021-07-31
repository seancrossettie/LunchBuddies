using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LunchBuddy (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void eat()
        {
            var restruant = new Restruant();
            Console.WriteLine($"{FirstName} {LastName} is eating at {restruant.Name}.");
        } 

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} is eating {food} at the office.");
        }

        public void eat(List<LunchBuddy> companions)
        {
            var restruant = new Restruant();
            Console.WriteLine($"Your friend, {FirstName} {LastName} is at {restruant.Name} with the following friends:");

            foreach(var companion in companions)
            {
                Console.WriteLine($"{companion.FirstName} {companion.LastName}");
            }
        }
    }
}
