using System;

namespace Homework_Feb16_part2
{
    public class Validation
    {
        Menu menu = new Menu();

        public bool IsAuthorized(string firstName, string secondName)
        {
            
            var user = new UserInfo();
            return (firstName.Equals(user.UserFirstName) && secondName.Equals(user.UserSecondName));
        }

        public bool IsCorrectInput()
        {
            return false;
        }
    }
}