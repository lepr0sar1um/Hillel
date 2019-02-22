using System;

namespace Homework_Feb16_part2
{
    public class Menu
    {
        private byte _selector;
        
        public void ShowMenu()
        {
            
            var isValid = new Validation();

            Console.WriteLine("Please, select one option:\n+" +
                              "1. View accounts\n+" +
                              "2. View this month debt\n+" +
                              "3. Payments history\n+" +
                              "4. Pay the bills\n+" +
                              "0. Exit");

            while (true)
            {
                try
                {
                    _selector = Convert.ToByte(Console.ReadLine());
                    SelectMenuItem(_selector);
                    break;
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                    isValid.IncorrectInput();
                    continue;
                }
            }
        }
        
        private static void SelectMenuItem(byte selector)
        {
            var user = new UserInfo();
            var options = new Options();
            switch (selector)
            {
                case 1:
                    user.GetUserAccounts();
                    break;

                case 2:
                    user.GetUserDebt();
                    break;

                case 3:
                    user.GetUserPaymentsHistory();
                    break;

                case 4:
                    options.PayTheBills();
                    break;

                case 0:
                    Console.WriteLine("Have a good day!");
                    break;
            }
        }
    }
}