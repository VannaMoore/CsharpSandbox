using ConsoleSkillLab.Utilities;


namespace ConsoleSkillLab.Exercises
{
    internal class NumbersBucketGame
    {
        public static void Bucket()
        {
            bool keepGoing = false;
            do
            {
                Helpers.PickAnyNumber();
                string? numString = Console.ReadLine();
                if (int.TryParse(numString, out int num))
                {
                    int evenOrOdd = num % 2;

                    if (num == 0)
                    {
                        Console.WriteLine("Number Bucket: Zero");
                    }
                    else if (num > 0 && evenOrOdd != 0)
                    {
                        Console.WriteLine("Number Bucket: Positive Odd");
                    }
                    else if (num < 0 && evenOrOdd != 0)
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
                }
                else
                {
                    Console.WriteLine("That is not valid input.");
                }

                keepGoing = Helpers.Continue(); // Need to handle input validation
            }
            while (keepGoing);

            Menu.MainMenu();
        }
    }
}
