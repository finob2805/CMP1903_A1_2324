﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program // main program where other classes are are utilised
    {
        static void Main(string[] args)
        {   
            Game PlayGame = new Game(); //creates game object
            PlayGame.DiceStatsAndReport(); //calls method
            Testing GameTest = new Testing(); // creates testing object
            GameTest.TestingGame(); // calls method
        }
    }
}