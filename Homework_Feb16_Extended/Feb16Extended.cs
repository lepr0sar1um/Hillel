using System;

namespace Homework_Feb16_part2
{
    public class Feb16Extended
    {
        private const string USER_FIRST_NAME = "Ivan";
        private const string USER_SECOND_NAME = "Eremenko";
        private const short HOTWATER_ACCOUNT = 1111;
        private const short ELECTRICITY_ACCOUNT = 2222;
        private const short HEATING_ACCOUNT = 3333;
        private const short GAS_ACCOUNT = 4444;
        

        public static void Main(string[] args)
        {
            Authorization();
            ShowMenu();
            GetUserAccounts();
        }
        
        private static void Authorization()
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Please, input you name: ");
                var firstName = Console.ReadLine();

                Console.Write("Please, input your second name: ");
                var secondName = Console.ReadLine();

                if (IsAuthorized(firstName, secondName))
                {
                    ShowMenu();
                    break;
                }
                IncorrectInput();
            }

        }

        private static bool IsAuthorized(string firstName, string secondName)
        {
            return (firstName.Equals(USER_FIRST_NAME) && secondName.Equals(USER_SECOND_NAME));
        }


        private static void GetUserAccounts()
        {
            Console.WriteLine("Accounts:");
            Console.WriteLine("Hot water:     {0}", HOTWATER_ACCOUNT);
            Console.WriteLine("Electricity:   {0}", ELECTRICITY_ACCOUNT);
            Console.WriteLine("Heating:       {0}", HEATING_ACCOUNT);
            Console.WriteLine("Gas:           {0}", GAS_ACCOUNT);
        }

        private static void UserPayments()
        {
            
        }

        private static void IncorrectInput()
        {
            Console.WriteLine("Incorrect input! Please, enter correct data.");
            WaitForUSer();
        }
        
        private static void WaitForUSer()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ShowMenu()
        {
            
        }
    }
}