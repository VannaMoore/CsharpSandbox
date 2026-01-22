using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSkillLab.Utilities
{
    internal static class Helpers
    {
        public static Boolean Continue()
        {
            Console.WriteLine("Press 'y' to continue or any other key to return to the main menu. \n");
            string? choice = Console.ReadLine();

            if (choice == "y" || choice == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PickAnyNumber()
        {
            Console.WriteLine("Pick any number (positive or negative).");
        }

        public static void HowOldAreYou()
        {
            Console.WriteLine("How old are you?");
        }
    }
}
