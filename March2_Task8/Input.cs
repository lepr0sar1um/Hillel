using System;

namespace March2_Task8
{
    public class Input
    {
        public void InputValues()
        {

            while (true)
            {
                Console.Write("Please, input first number: ");
                if (int.TryParse(Console.ReadLine(), out var firstNumber))
                {
                    Console.Write("Please, input second number: ");
                    if (int.TryParse(Console.ReadLine(), out var secondNumber))
                    {
                        var process = new Logic();
                        process.ProcessValues(firstNumber, secondNumber);
                        break;
                    }
                }
                Console.WriteLine("Please, input only digits!");
            }
        }
    }
}
