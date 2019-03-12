using System;

namespace March2_Task8
{
    public class Logic
    {
        public void ProcessValues(int firstNumber, int secondNumer)
        {
            if (!firstNumber.Equals(secondNumer))
            {
                var firstValue = firstNumber + secondNumer;
                var secondValue = secondNumer + firstNumber;
                Console.WriteLine($"New values are: {firstValue}, {secondValue}");
                Console.ReadLine();
            }
            else
            {
                firstNumber = secondNumer = 0;
                Console.WriteLine($"New values are: {firstNumber}, {secondNumer}");
                Console.ReadLine();
            }
        }
    }
}