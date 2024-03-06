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
        Die Die_1 = new Die();
        Die Die_2 = new Die();
        Die Die_3 = new Die();

        public int[] DiceStatsAndReport()
        {
            int[] diceRoll_List = {Die_1.DiceRoll(), Die_2.DiceRoll(), Die_3.DiceRoll()}; // creates array for storing the number that comes from the rolls
            int sum = 0; // create sum variable
            for (int count = 0; count <=2; count++) // for loop goes through the array and adds up dice rolls
            {
                sum = sum + diceRoll_List[count];
                Console.WriteLine("This die (" + (count+1) + ") rolled " + diceRoll_List[count]); // outputs what the die rolled
            }
            Console.WriteLine("The total of the 3 rolls was " + sum); // outputs sum of rolls
            return diceRoll_List; // returns the list
        }

    }
}
