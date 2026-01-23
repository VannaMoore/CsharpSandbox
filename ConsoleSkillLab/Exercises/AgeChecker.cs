using System;
using ConsoleSkillLab.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSkillLab.Exercises
{
    internal class AgeChecker
    {
        public static void CheckUserAge()
        {
            int birthYear = Helpers.UserBirthYear();
            int userAge = 0;

            Console.WriteLine("Have you had a birthday this year (y/n)?");
            string? answer = Console.ReadLine()?.ToLower();

            
            if (answer == "y")
            {
                userAge = 2026 - birthYear;
            }
            else if (answer == "n")
            {
                userAge = 2025 - birthYear;
            }

            if (userAge > 0)
            {
                Console.WriteLine($"You are {userAge} years old.");
            }
            else
            {
                Console.WriteLine("Unable to calculate age based on user input.");
            }

            if (userAge < 16)
            {
                Console.WriteLine("You are not old enough to drive, vote, gamble or drink.");
            }
            else if (userAge < 18 && userAge >= 16)
            {
                Console.WriteLine("You are not old enough to vote, drink, gamble, or have a driver's license.");
                Console.WriteLine("You are old enough to have a learners permit.");
            }
            else if (userAge >= 18 && userAge <= 21)
            {
                Console.WriteLine("You are old enough to vote and drive.");
                Console.WriteLine("You are not old enough to drink or gamble.");
            }
            else
            {
                Console.WriteLine("You are old enough to drive, vote, drink and gamble.");
            }
            

            bool keepGoing = Helpers.Continue();
            if (keepGoing)
            {
                CheckUserAge();
            }
            else
            {
                Menu.MainMenu();
            }

        }
    }
}
