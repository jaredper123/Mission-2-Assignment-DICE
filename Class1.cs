using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2_Assignment_DICE
{
    class ThrowDice
    {
        public void StartRoll(int diceNum)
        {
            Random rnd1 = new Random();
            int[] possNums = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            for(int i=1; i <= diceNum; i++)
            {
                int roll1 = rnd1.Next(1, 7);
                int roll2 = rnd1.Next(1, 7);

                int finRoll = roll1 + roll2;
                int arrayIndex = finRoll - 2;

                possNums[arrayIndex] = possNums[arrayIndex] + 1;
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + diceNum);
            double percentRoll = diceNum / 100.0;
            
            for(int j=0; j < possNums.Length; j++)
            {
                int holderNum = possNums[j];
                string asteriskChart = "";
                if (percentRoll <= holderNum)
                {
                    asteriskChart = "*";
                    for (double k = percentRoll; k < holderNum; k = k + percentRoll)
                    {
                        asteriskChart += "*";
                    }
                }
                Console.WriteLine((j + 2) + ": " + asteriskChart);
            }


            GamePrompt();
        }
        
        public void GamePrompt()
        {
            Console.Write("Would you like to roll again? (y/n)");
            string response = Console.ReadLine();
            if (response == "y")
            {
                Program.Main(null);
            }
            else
            {
                Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
            }
        }
    }
}
