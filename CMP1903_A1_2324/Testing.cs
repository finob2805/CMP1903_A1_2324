using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public void testing()
        {
            Game play_game = new Game(); // creates game object
            Console.WriteLine("----------TESTING----------"); //signifies that this run is a test run to verify the numbers we expect are correct
            int[] diceRoll_list = play_game.DiceStatsAndReport(); // calls method from Game class
            int sum = 0;
            for (int count = 0; count <=2; count++) // loop checks that each roll is between 1 and 6, if not then an error message will display
            {
                Debug.Assert(diceRoll_list[count] >= 1 && diceRoll_list[count] <=6, "The number die " + (count+1) + " rolled WASN'T between 1 and 6 so there is an error");
                sum = sum + diceRoll_list[count];
                if (count == 2) // checks to see if the loop is on its final iteration
                {
                    Debug.Assert(sum >= 6 && sum <= 18, "The sum of the rolls was NOT between 6 and 18 - Error has occured"); // checks sum to make sure it is betweem 6 and 18
                    // if not, error message will display
                }
            }
        }
    }
}