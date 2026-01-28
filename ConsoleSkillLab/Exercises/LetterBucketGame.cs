using System;
using ConsoleSkillLab.Utilities;

namespace ConsoleSkillLab.Exercises
{
    internal class LetterBucketGame
    {
        public static void LetterBucket()
        {
            bool keepGoing = false;

            do
            {
                Console.Write("Enter a string: ");
                string? originalString = Console.ReadLine();
                string standardString;
                string charType;
                int vowel = 0;
                int consonant = 0;

                if (originalString == null)
                {
                    Console.WriteLine("Please enter a valid string.");
                }
                else
                {
                    standardString = originalString.ToLower();

                    foreach (char i in standardString)
                    {
                        charType = Helpers.ConsonantOrVowelOrNeither(i);
                        if (charType == "vowel")
                        {
                            vowel++;
                        }
                        else if (charType == "consonant")
                        {
                            consonant++;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    Console.WriteLine($"\nVowels: {vowel}");
                    Console.WriteLine($"Consonants: {consonant}\n");
                }

                keepGoing = Helpers.Continue();
            }
            while (keepGoing);

            Menu.MainMenu();
        }
    }
}
