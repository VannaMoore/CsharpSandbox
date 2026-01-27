using System;
using ConsoleSkillLab.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSkillLab.Exercises
{
    internal class LetterBucketGame
    {
        public static void LetterBucket()
        {
            bool keepGoing = false;

            do
            {
                Console.WriteLine("Enter a string.");
                string? originalString = Console.ReadLine();
                string standardString;

                if (originalString == null)
                {
                    Console.WriteLine("Please enter a valid string.");
                }
                else
                {
                    standardString = originalString.ToLower();

                    foreach (char i in standardString)
                    {

                    }
                }

                



                keepGoing = Helpers.Continue();
            }
            while (keepGoing);
        }
    }
}
