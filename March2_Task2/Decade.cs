using System;

namespace March2_Task2
{
    public class Decade
    {
        public void FindDecade(int newValue)
        {
            var result =  newValue / 10;
            Console.WriteLine("There are {0} decade", result);
        }
    }
}