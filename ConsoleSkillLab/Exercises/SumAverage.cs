using ConsoleSkillLab.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSkillLab.Exercises
{
    internal class SumAverage
    {
        public static void SumAndAverage()
        {
            int[] userNums = new int[5];
            int sum = 0;
            float avg;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number.");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int userNum))
                {
                    userNums[i] = userNum;
                    Console.WriteLine($"Index {i}: {userNum}\n");
                }
                else
                {
                    Console.WriteLine("That is not valid input. Enter a number.\n");
                    i--;
                } 
            }

            for (int i = 0; i < 5; i++)
            {
                sum += userNums[i];
            }

            avg = (float)sum / userNums.Length;

            Console.WriteLine($"\nSum: {sum}");
            Console.WriteLine($"Average: {avg}\n");

            bool userInput = Helpers.Continue();
            if (userInput)
            {
                SumAndAverage();
            }
            else
            {
                Menu.MainMenu();
            }
        }
    }
}
