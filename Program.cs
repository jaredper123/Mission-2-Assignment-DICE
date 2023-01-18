using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2_Assignment_DICE
{
    class Program
    {
        public static void Main(string[] args = null)
        {
            ThrowDice game = new ThrowDice();

            Console.Write("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate? ");
            int diceAmount = Convert.ToInt32(Console.ReadLine());

            game.StartRoll(diceAmount);
        }
    }
}
