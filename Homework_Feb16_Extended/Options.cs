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
}