using System;

namespace March2_Task10
{
    public class Logic
    {
        public void ProcessValue(double value, double multiplier)
        {
            double result = value * multiplier;
            Console.WriteLine($"It will be {result} meters");
            
            Console.ReadLine();
        }
    }
}