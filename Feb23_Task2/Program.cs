using System;
using System.Runtime.InteropServices;

namespace Feb23_Task2
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            var even = new EvenPercent();
            var odd = new OddPercent();
            
            while (true)
            {
                Console.Write("Please, input value between 100 and 100000000: ");

                if (long.TryParse(Console.ReadLine(), out var inputValue))
                {
                    if (inputValue >= 100 && inputValue <= 100000000)
                    {
                        Console.WriteLine("Input value has {0}% even and {1}% odd values", 
                            even.EvenPerc(inputValue), odd.OddPerc(inputValue));
                        break;
                    }
                }
                ParseNumbersException();
            }
        }
        
        private static void WaitForUser()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void ParseNumbersException()
        {
            Console.WriteLine("Please, input correct value!");
            WaitForUser();
        }
    }
}