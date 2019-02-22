using System;

namespace Homework_Feb16_part2
{
    public class UserInfo
    {
        private string userFirstName = "Ivan";
        private string userSecondName = "Eremenko";
        private short hotWaterAccount = 1111;
        private short electricityAccount = 2222;
        private short heatingAccount = 3333;
        private short gasAccount = 4444;

        public string UserFirstName => userFirstName;
        public string UserSecondName => userSecondName;
        public short HotWaterAccount => hotWaterAccount;
        public short ElectricityAccount => electricityAccount;
        public short HeatingAccount => heatingAccount;
        public short GasAccount => gasAccount;


        public static void GetUserPaymentsHistory()
        {
            //Сгенерировать случайную историю платежей
        }
        
        public static void GetUserDebt()
        {
            //Добавить ввод показаний и расчет долга на их основе
        }

        public int[] userAccount = { };

    }
}