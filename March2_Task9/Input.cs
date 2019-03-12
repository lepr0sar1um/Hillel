using System;

namespace March2_Task9
{
    public class Input
    {
        public void InputValues()
        {

            while (true)
            {
                Console.Clear();
                
                Console.Write("Please, input first number: ");
                if (double.TryParse(Console.ReadLine()?.Replace(',', '.'), out var value))
                {
                    var process = new Logic();
                    Console.WriteLine("Is even: " + process.IsEvent(value));
                    break;
                }
                Console.WriteLine("Please, input only numbers!");
                Console.ReadLine();
            }
        }
    }
}
    