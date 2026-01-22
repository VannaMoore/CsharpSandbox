using System;


namespace ConsoleSkillLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            Console.WriteLine("\nYou just hit a key. This is the next line of code. This is control flow.");
            Console.ReadKey();
            Console.WriteLine();

            Menu.MainMenu();
        }
    }
}



// *** ReadLine Casting *** //
// int num = Convert.ToInt32(Console.ReadLine());