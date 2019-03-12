using System;

namespace March2_Task1
{
    public class Swap
    {
        public void SwapValues(double a, double b, double c)
        {

            var temp = b;
            b = a;
            a = c;
            c = temp;

            Console.WriteLine("New values are {0} {1} {2}", a, b, c);
        }
    }
}