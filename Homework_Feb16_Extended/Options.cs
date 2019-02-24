using System;
using System.Runtime.InteropServices;

namespace Homework_Feb16_part2
{
    public class Options
    {
        private readonly Menu _menu = new Menu();

        public void Authorization()
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

        public void Registration()
        {
            
        }
        
        public void GetUserPaymentsHistory()
        {
            //Сгенерировать случайную историю платежей
            
            _menu.WaitForUSer();
            _menu.ShowMenu();
        }
        
        public void GetUserDebt()
        {
            //Добавить ввод показаний и расчет долга на их основе
            
            _menu.WaitForUSer();
            _menu.ShowMenu();
        }

        public void GetUserAccounts()
        {
            Console.Clear();

        }

        
        public void PayTheBills()
        {
            //Что-то придумать, эмулируещее оплату
            
            _menu.WaitForUSer();
            _menu.ShowMenu();
        }
    }
}