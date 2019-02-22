using System;
using System.Runtime.InteropServices;

namespace Homework_Feb16_part2
{
    public class Options
    {   
        Menu menu = new Menu();
        
        private short hotWaterAccount = 1111;
        private short electricityAccount = 2222;
        private short heatingAccount = 3333;
        private short gasAccount = 4444;
        public short HotWaterAccount => hotWaterAccount;
        public short ElectricityAccount => electricityAccount;
        public short HeatingAccount => heatingAccount;
        public short GasAccount => gasAccount;
        
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
            
            menu.WaitForUSer();
            menu.ShowMenu();
        }
        
        public void GetUserDebt()
        {
            //Добавить ввод показаний и расчет долга на их основе
            
            menu.WaitForUSer();
            menu.ShowMenu();
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

            var water = ("Hot water account:", HotWaterAccount);
            var electricity = ("Electricity account:", ElectricityAccount);
            var heating = ("Heating account:", HeatingAccount);
            var gas = ("Gas account:", GasAccount);
            

            //foreach (var account in Accounts)
            //{
            //    Console.WriteLine(account);
            //}

            Console.WriteLine(water +"\n" + gas + "\n" + heating + "\n" + electricity);
            
            menu.WaitForUSer();
            menu.ShowMenu();
        }

        
        public void PayTheBills()
        {
            //Что-то придумать, эмулируещее оплату
            
            menu.WaitForUSer();
            menu.ShowMenu();
        }
    }
}