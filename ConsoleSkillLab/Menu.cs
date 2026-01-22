using System;
using ConsoleSkillLab.Exercises;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSkillLab
{
    internal class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("Choose a menu option:");
            Console.WriteLine("1. Numbers Bucket Game");
            Console.WriteLine("2. Age checker");
            Console.WriteLine("3. End Program");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    NumbersBucketGame.Bucket();
                    break;
                case 2:
                    AgeChecker.UserAge();
                    break;
                case 3:
                    break;

            }
        }
    }
}
