using System;

namespace Feb23_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mult = new Multiplication();
            var sum = new Sum();
            while (true)
            {
                
                Console.Write("Please, input first number: ");
                if (double.TryParse(Console.ReadLine(), out var firstNumber))
                {
                    Console.Write("Please, input second number: ");
                    if (double.TryParse(Console.ReadLine(), out var secondNumber))
                    {
                        Console.Write("Please, input third number: ");
                        if (double.TryParse(Console.ReadLine(), out var thirdNumber))
                        {
                            Console.WriteLine("OK. Sum of those numbers is {0} ",
                                sum.Amount(firstNumber, secondNumber, thirdNumber));
                            Console.WriteLine("And multiplication is: {0}", 
                                mult.Mult(firstNumber, secondNumber, thirdNumber));

                            WaitForUser();
                            break;
                        }
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
            Console.WriteLine("Please, use only numbers!");
            WaitForUser();
        }
    }
}