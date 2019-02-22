using System;

namespace Homework_Feb16_part2
{
    public class Menu
    {
        private byte selector;
        
        public void ShowMenu()
        {
            Console.Clear();
            
            var check = new Validation();

            Console.Write("1. View accounts\n" +
                              "2. View this month debt\n" +
                              "3. Payments history\n" +
                              "4. Pay the bills\n" +
                              "0. Exit\n"+
                              "Please, select one option: ");

            while (true)
            {
                try
                {
                    selector = Convert.ToByte(Console.ReadLine());
                    SelectMenuItem(selector);
                    break;
                }
                catch (FormatException)
                {
                    check.IsCorrectInput();
                }
            }
        }
        
        private static void SelectMenuItem(byte selector)
        {
            var options = new Options();
            switch (selector)
            {
                case 1:
                    options.GetUserAccounts();
                    break;

                case 2:
                    options.GetUserDebt();
                    break;

                case 3:
                    options.GetUserPaymentsHistory();
                    break;

                case 4:
                    options.PayTheBills();
                    break;

                case 0:
                    Console.WriteLine("Have a good day!");
                    break;
            }
        }
        
        public void WaitForUSer()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}