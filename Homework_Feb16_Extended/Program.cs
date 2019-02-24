using System;

namespace Homework_Feb16_part2
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program can show you your accounts.\n" +
                              "You can select account, view its info, pay.\n" +
                              "Please, login or register");
            
            var user = new Menu();
            user.WaitForUSer();
            
            var auth = new Options{};
            auth.Authorization();
            
        }
    }
}