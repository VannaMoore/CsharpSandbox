using System;
using ConsoleSkillLab.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Future exercise: Make it to where the user chooses the array size from the start.

namespace ConsoleSkillLab.Exercises
{
    internal class ReverseListPrint
    {
        // Have the user enter 5 integers in an array.
        // Use a loop to print them in reverse order.
        // Constraint: Don't modify the array
        public static void Reverse()
        {
            int[] numbersList = new int[5];
            int[] reverseNumbersList = new int[5];
            int current = 0;

            Console.WriteLine("You will be prompted to enter 5 numbers that will be put into an array.");
            Console.WriteLine("The program will print them back in the reverse order in which they were entered.\n");

            for (int i = 0; i < numbersList.Length; i++)
            {
                Console.Write("Enter a number: ");
                string? userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int userNumber))
                {
                    numbersList[i] = userNumber;
                }
                else
                {
                    Console.WriteLine("That is not valid input. Enter a number.");
                    i--;
                }
            }

            Console.WriteLine("\nReverse Numbers List:");
            for(int i = numbersList.Length - 1; i >= 0; i--)
            {
                reverseNumbersList[current] = numbersList[i];
                Console.WriteLine($"Index {current}: {numbersList[i]}");
                current++;
            }
            Console.WriteLine();

            bool keepGoing = Helpers.Continue();
            if (keepGoing)
            {
                Reverse();
            }
            else
            {
                Menu.MainMenu();
            }
        }
    }
}
