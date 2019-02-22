using System;

namespace Homework_Feb16_part2
{
    public class Options
    {   
        public void Authorization()
        {
            var menu = new Menu();
            var isValid = new Validation();

            while (true)
            {
                Console.Clear();

                Console.Write("Please, input you name: ");
                var firstName = Console.ReadLine();

                Console.Write("Please, input your second name: ");
                var secondName = Console.ReadLine();

                if (isValid.IsAuthorized(firstName, secondName))
                {
                    menu.ShowMenu();
                    break;
                }
                isValid.IsCorrectInput();
            }
        }
        
        public void PayTheBills()
        {
            //Что-то придумать, эмулируещее оплату
        }
        
        private static void WaitForUSer()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}