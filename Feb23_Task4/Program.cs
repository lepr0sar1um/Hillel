using System;
using System.Linq;

namespace Feb23_Task4
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                
                Console.Write("Input value: ");
                var value = (Console.ReadLine());
                
                if (value?.Length != 3)
                {
                    Console.WriteLine("Please, input only 3 digits");
                    Console.ReadLine();
                    continue;
                }
                
                try
                {
                    Convert.ToInt16(value);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.ReadLine();
                    continue;
                }

                var reverse = short.Parse(new string(value.Reverse().ToArray()));
 
                Console.Write("Reverse is: {0}",  reverse);
                Console.ReadKey();
                break;
            }
        }
    }
}