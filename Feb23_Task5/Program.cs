using System;

namespace Feb23_Task5
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                                
                Console.Write("Input value: ");
                var value = (Console.ReadLine());

                if (value?.Length == 3 && (int.TryParse(value, out var newValue)))
                {
                    Console.WriteLine("Result is {0}", Result(newValue));
                    break;
                }
                Console.WriteLine("Please, input only 3 digits");
                Console.ReadLine();
            }
        }

        private static int Result(int value)
        {
            return (value / 100) * 10 + (value - (value  / 10 ) * 10) + (value / 10 - value / 100 * 10) *100;
        }
    }
}