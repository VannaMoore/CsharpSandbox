using System;
using ConsoleSkillLab.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSkillLab.Exercises
{
    internal class NumbersBucketGame
    {
        public static void Bucket()
        {
            Helpers.PickAnyNumber();
            int num = Convert.ToInt32(Console.ReadLine());
            int evenOrOdd = num % 2;

            if (num == 0)
            {
                Console.WriteLine("Number Bucket: Zero");
            }
            else if (num > 0 && evenOrOdd > 0)
            {
                Console.WriteLine("Number Bucket: Positive Odd");
            }
            else if (num < 0 && evenOrOdd > 0)
            {
                Console.WriteLine("Number Bucket: Negative Odd");
            }
            else if (num > 0 && evenOrOdd == 0)
            {
                Console.WriteLine("Number Bucket: Positive Even");
            }
            else if (num < 0 && evenOrOdd == 0)
            {
                Console.WriteLine("Number Bucket: Negative Even");
            }
            else
            {
                Console.WriteLine("That is not a valid integer. Enter a numeric value.");
            }

            bool userInput = Helpers.Continue();
            if (userInput)
            {
                Bucket();
            }
            else
            {
                Menu.MainMenu();
            }
        }
    }
}
