using System;

namespace Homework_Feb16_part2
{
    public class Feb16Extended
    {
        private const string USER_FIRST_NAME = "Ivan";
        private const string USER_SECOND_NAME = "Eremenko";

        public static void Main(string[] args)
        {
            
        }
        
        private static void Authorization()
        {
            var tryAgain = true;
            Console.WriteLine("Please, input you name: ");
            var firstName = Console.ReadLine();

            Console.WriteLine("Please, input your second name: ");
            var secondName = Console.ReadLine();

            if (IsUserEquels(firstName, secondName))
            {
                ShowMenu();  
            }
            else
            {
                Console.WriteLine("Incorrect data. Please, try again.");
                WaitForUSer();
            }
        }

        private static bool IsUserEquels(string firstName, string secondName)
        {
            return (firstName.Equals(USER_FIRST_NAME) && secondName.Equals(USER_SECOND_NAME));
        }

        private static void WaitForUSer()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ShowMenu()
        {
            
        }

        private static void ExistData()
        {
            
        }
    }
}