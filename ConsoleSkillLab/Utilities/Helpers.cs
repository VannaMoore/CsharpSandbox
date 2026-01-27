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

        public static int UserBirthYear()
        {
            Console.WriteLine("What year were you born?");
            string? birthYearInput = Console.ReadLine();
            if (int.TryParse(birthYearInput, out int birthYear)) { }
            else
            {
                Console.WriteLine("That is not a valid year.");
                return UserBirthYear();
            }

            if (birthYear <= 1800)
            {
                Console.WriteLine("That is not a valid year.");
                return UserBirthYear();
            }
            return birthYear;
        }

        public static string ConsonantOrVowelOrNeither(char letter)
        {
            string classification;

            if (letter >= 'a' && letter <= 'z')
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    classification = "vowel";
                }
                else
                {
                    classification = "consonant";
                }
            }
            else
            {
                classification = "neither";
            }


            return classification;
        }

    }
}
