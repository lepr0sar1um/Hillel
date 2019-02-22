using System;
using System.Runtime.InteropServices;

namespace Homework_Feb16_part2
{
    public class Validation
    {
        public bool IsAuthorized(string firstName, string secondName)
        {
            var user = new UserInfo();
            return (firstName.Equals(user.UserFirstName) && secondName.Equals(user.UserSecondName));
        }

        public void IsCorrectInput()
        {
            var menu = new Menu();

            Console.WriteLine("Incorrect input! Please, enter correct data.");
            menu.WaitForUSer();
        }
    }
}