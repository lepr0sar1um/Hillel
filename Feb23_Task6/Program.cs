using System;

namespace Feb23_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                                
                Console.Write("Input value: ");
                var value = (Console.ReadLine());

                if (value?.Length == 2 && (int.TryParse(value, out var newValue)))
                {
                    FindUnits(newValue);
                    FindDecade(newValue);
                    FindSum(newValue);
                    FindMulti(newValue);
                    break;
                }
                Console.WriteLine("Please, input only 2 digits");
                Console.ReadLine();
            }
        }

        private static void FindUnits(int newValue)
        {
            var result =  newValue % 10;
            Console.WriteLine("There are {0} units", result);
        }

        private static void FindDecade(int newValue)
        {
            var result =  newValue / 10;
            Console.WriteLine("There are {0} decade", result);
        }

        private static void FindSum(int newValue)
        {
            var result = (newValue % 10) + (newValue / 10);
            Console.WriteLine("The sum is {0}", result);
            
        }

        private static void FindMulti(int newValue)
        {
            var result = (newValue % 10) * (newValue / 10);
            Console.WriteLine("Result of multiplication is {0}", result);

        }
    }
}