using System;

namespace Homework_Feb16_part2
{
    public class Validation
    {
        Menu menu = new Menu();
        Options forward = new Options();
        public bool IsAuthorized(string firstName, string secondName)
        {
            var user = new UserInfo();
            return (firstName.Equals(user.UserFirstName) && secondName.Equals(user.UserSecondName));
        }

        public void IsCorrectInput()
        {
            Console.Clear();

            Console.WriteLine("Incorrect input! Please, enter correct data.");
            menu.WaitForUSer();
            forward.Authorization();
        }
    }
}