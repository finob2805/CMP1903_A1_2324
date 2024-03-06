using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // creates 3 die objects
        Die Die1 = new Die();
        Die Die2 = new Die();
        Die Die3 = new Die();

        public int[] DiceStatsAndReport()
        {
            int[] DiceRollList = {Die1.DiceRoll(), Die2.DiceRoll(), Die3.DiceRoll()}; // creates array for storing the number that comes from the rolls
            int Sum = 0; // create sum variable
            for (int Count = 0; Count <=2; Count++) // for loop goes through the array and adds up dice rolls
            {
                Sum = Sum + DiceRollList[Count];
                Console.WriteLine("This die (" + (Count+1) + ") rolled " + DiceRollList[Count]); // outputs what the die rolled
            }
            Console.WriteLine("The total of the 3 rolls was " + Sum); // outputs sum of rolls
            return DiceRollList; // returns the list
        }

    }
}
