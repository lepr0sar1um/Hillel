using System;

namespace March2_Task5
{
    public class Input
    {
        public void InputValues()
        {
            var process = new Logic();
            while (true)
            {
                Console.Clear();
                                
                Console.Write("Input value: ");
                var value = (Console.ReadLine()?.Replace(',', '.'));

                if (double.TryParse(value, out var newValue))
                {
                    Console.WriteLine("New value is {0}", process.ProcessValue(newValue));
                    break;
                }
                Console.WriteLine("Please, input only numbers");
                Console.ReadLine();
            }
        }
    }
}