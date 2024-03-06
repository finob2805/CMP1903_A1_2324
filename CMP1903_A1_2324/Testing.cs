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
        public void TestingGame()
        {
            Game TestGame = new Game(); // creates game object
            Console.WriteLine("----------TESTING----------"); //signifies that this run is a test run to verify the numbers we expect are correct
            int[] DiceRollList = TestGamegame.DiceStatsAndReport(); // calls method from Game class
            int Sum = 0;
            for (int Count = 0; Count <=2; Count++) // loop checks that each roll is between 1 and 6, if not then an error message will display
            {
                Debug.Assert(DiceRollList[Count] >= 1 && DiceRollList[Count] <=6, "The number die " + (Count+1) + " rolled WASN'T between 1 and 6 so there is an error");
                Sum = Sum + DiceRollList[Count];
                if (Count == 2) // checks to see if the loop is on its final iteration
                {
                    Debug.Assert(Sum >= 3 && Sum <= 18, "The sum of the rolls was NOT between 6 and 18 - Error has occured"); // checks sum to make sure it is betweem 6 and 18
                    // if not, error message will display
                }
            }
        }
    }
}