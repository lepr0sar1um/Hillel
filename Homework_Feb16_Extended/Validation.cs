using System;

namespace Homework_Feb16_part2
{
    public class Validation
    {
        public bool IsAuthorized(string firstName, string secondName)
        {
            var user = new UserInfo();
            return (firstName.Equals(user.UserFirstName) && secondName.Equals(user.UserSecondName));
        }

        public void IncorrectInput()
        {
            Console.WriteLine("Incorrect input! Please, enter correct data.");
            WaitForUSer();
        }
    }
}