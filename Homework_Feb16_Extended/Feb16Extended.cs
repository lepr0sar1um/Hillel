using System;

namespace Homework_Feb16_part2
{

    public class Options
    {
        public void Authorization()
        {

            while (true)
            {
                Console.Clear();

                Console.Write("Please, input you name: ");
                var firstName = Console.ReadLine();

                Console.Write("Please, input your second name: ");
                var secondName = Console.ReadLine();

                if (Menu.IsAuthorized(firstName, secondName))
                {
                    Menu.ShowMenu();
                    break;
                }
                Menu.IncorrectInput();
            }

        }
    }
    
    class Menu
    {
        private const string USER_FIRST_NAME = "Ivan";
        private const string USER_SECOND_NAME = "Eremenko";
        private const short HOTWATER_ACCOUNT = 1111;
        private const short ELECTRICITY_ACCOUNT = 2222;
        private const short HEATING_ACCOUNT = 3333;
        private const short GAS_ACCOUNT = 4444;
        private byte _selector;
        

        public static void Main(string[] args)
        {
            Console.WriteLine("This program can show you your accounts.\n +" +
                              "You can select account, view its info, pay.\n" +
                              "Please, login to get access");
            
            var auth = new Options{};
            auth.Authorization();
            
        }
        


        public static bool IsAuthorized(string firstName, string secondName)
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

        private static void GetUserPaymentsHistory()
        {
            //Сгенерировать случайную историю платежей
        }
        
        private static void GetUserDebt()
        {
            //Добавить ввод показаний и расчет долга на их основе
        }
        
        private static void PayTheBills()
        {
            //Что-то придумать, эмулируещее оплату
        }

        public static void IncorrectInput()
        {
            Console.WriteLine("Incorrect input! Please, enter correct data.");
            WaitForUSer();
        }
        
        private static void WaitForUSer()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private void SelectMenuItem(byte selector)
        {
            switch (selector)
            {
                case 1:
                    GetUserAccounts();
                    break;

                case 2:
                    GetUserDebt();
                    break;

                case 3:
                    GetUserPaymentsHistory();
                    break;

                case 4:
                    PayTheBills();
                    break;

                case 0:
                    Console.WriteLine("Have a good day!");
                    break;
            }
        }

        public static void ShowMenu()
        {

            Console.WriteLine("Please, select one option:\n+" +
                              "1. View accounts\n+" +
                              "2. View this month debt\n+" +
                              "3. Payments history\n+" +
                              "4. Pay the bills\n+" +
                              "0. Exit");

            var repeat = true;

            while (repeat)
            {
                try
                {
                    _selector = Convert.ToByte(Console.ReadLine());
                    repeat = false;
                    SelectMenuItem(_selector);
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                    IncorrectInput();

                    continue;
                }
            }
        }
    }
}