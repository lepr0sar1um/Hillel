using System;

namespace March2_Task1
{
    public class Input
    {
        public void InputValues()
        {
            var swap = new Swap();

            while (true)
            {
                Console.Clear();

                Console.Write("Please, input first value: ");
                if (double.TryParse(Console.ReadLine(), out var firstNumber))
                {
                    Console.Write("Please, input second value: ");
                    if (double.TryParse(Console.ReadLine(), out var secondNumber))
                    {
                        Console.Write("Please, input third value: ");
                        if (double.TryParse(Console.ReadLine(), out var thirdNumber))
                        {
                            swap.SwapValues(firstNumber, secondNumber, thirdNumber);
                            break;
                        }
                    }
                }
                ParseNumbersException();
            }
        }
        
        private void WaitForUSer()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private void ParseNumbersException()
        {
            Console.WriteLine("Please, use only numbers!");
            WaitForUSer();
        }
    }
}