using System;

namespace March2_Task6
{
    public class Logic
    {
        public void FindCounter(int[] valuesArray)
        {
            int countMin = 0, countMax = 0;

            foreach (var element in valuesArray)
            {
                if (element < 0 && element != 0)
                {
                    countMin++;
                }
                else
                {
                    countMax++;
                }
            }

            Console.WriteLine($"\nThere are {countMax} positive elements and {countMin} negative elements");
            Console.ReadLine();
        }
    }
}