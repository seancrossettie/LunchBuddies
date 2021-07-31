using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var sean = new LunchBuddy("Sean", "Rossettie");
            sean.eat();

            var matt = new LunchBuddy("Matt", "Vero");
            matt.eat("chicken");

            var aaron = new LunchBuddy("Aaron", "Young");

            var buddyList = new List<LunchBuddy>() { matt, sean };
            aaron.eat(buddyList);

            var blaze = new LunchBuddy("Blaze", "Blanke");

            blaze.eat("chicken", buddyList);
        }
    }
}
