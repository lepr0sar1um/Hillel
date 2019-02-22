using System;
using System.Runtime.InteropServices;

namespace Homework_Feb16_part2
{
    public class Options
    {
        private readonly Menu _menu = new Menu();

        private readonly short _hotWaterAccount = 1111;
        private readonly short _electricityAccount  = 2222;
        private readonly short _heatingAccount = 3333;
        private readonly short _gasAccount = 4444;

        public void Authorization()
        {
            var menu = new Menu();
            var check = new Validation();

            while (true)
            {
                Console.Clear();

                Console.Write("Please, input you name: ");
                var firstName = Console.ReadLine().ToLower();

                Console.Write("Please, input your second name: ");
                var secondName = Console.ReadLine().ToLower();

                if (check.IsAuthorized(firstName, secondName))
                {
                    menu.ShowMenu();
                    break;
                }
                check.IsCorrectInput();
            }
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
            
            /*List<short> Accounts = new List<short>()
            {
                HotWaterAccount,
                ElectricityAccount,
                HeatingAccount,
                GasAccount
            };*/

            var water = ("Hot water account:", HotWaterAccount: _hotWaterAccount);
            var electricity = ("Electricity account:", ElectricityAccount: _electricityAccount);
            var heating = ("Heating account:", HeatingAccount: _heatingAccount);
            var gas = ("Gas account:", GasAccount: _gasAccount);
            

            //foreach (var account in Accounts)
            //{
            //    Console.WriteLine(account);
            //}

            Console.WriteLine(water +"\n" + gas + "\n" + heating + "\n" + electricity);
            
            _menu.WaitForUSer();
            _menu.ShowMenu();
        }

        
        public void PayTheBills()
        {
            //Что-то придумать, эмулируещее оплату
            
            _menu.WaitForUSer();
            _menu.ShowMenu();
        }
    }
}