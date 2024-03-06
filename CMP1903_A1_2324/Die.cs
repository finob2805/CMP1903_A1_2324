using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die // creates Die class
    {
        public int current_die_value;  
        public int DiceRoll() // randomises a roll between 1 and 6 and then returns said roll in current_die_value
        {
            Random random_1to6 = new Random();
            current_die_value = random_1to6.Next(1, 7); //must be 7 as that means all numbers from 1 up to 7-1
            return current_die_value;
        }
    }
}
