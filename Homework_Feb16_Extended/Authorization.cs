using System;

namespace Homework_Feb16_part2
{
    public class Authorization
    {
        public void Login()
        {
            var menu = new Menu();
            var check = new Validation();

            while (true)
            {
                Console.Clear();

                Console.Write("Please, input you name: ");
                var firstName = Console.ReadLine();

                Console.Write("Please, input your second name: ");
                var secondName = Console.ReadLine();

                if (check.IsAuthorized(firstName, secondName))
                {
                    menu.ShowMenu();
                    break;
                }
                check.IsCorrectInput();
            }
        }
    }
}