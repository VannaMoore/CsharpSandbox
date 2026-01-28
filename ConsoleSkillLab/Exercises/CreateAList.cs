using ConsoleSkillLab.Utilities;

namespace ConsoleSkillLab.Exercises
{
    internal class CreateAList
    {
        public static void UserList()
        {
            List<string> userList = new List<string>();
            Console.WriteLine("Enter items (type 'done' to finish):");

            while (true)
            {
                string? item = Console.ReadLine();

                if (item == null || item.ToLower() == "done")
                    break;

                userList.Add(item);
            }

            foreach (string item in userList)
            {
                Console.WriteLine($"Item: {item}");
            }

            bool userInput = Helpers.Continue();
            if (userInput)
            {
                UserList();
            }
            else
            {
                Menu.MainMenu();
            }

        }
    }
}
