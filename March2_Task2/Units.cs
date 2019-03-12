using System;

namespace March2_Task2
{
    public class Units
    {
        public void FindUnits(int newValue)
        {
            var result =  newValue % 10;
            Console.WriteLine("There are {0} units", result);
        }

    }
}