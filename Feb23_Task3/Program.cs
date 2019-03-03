using System;

namespace Feb23_Task3
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                
                Console.Write("Input ticket number: ");
                var ticketNumber = Console.ReadLine();

                try
                {
                    Convert.ToInt32(ticketNumber);
                }
                catch (Exception exception)
                {
                    Console.Write(exception.Message);
                    Console.ReadLine();
                    continue;
                }
                
                if (ticketNumber == null || (ticketNumber.Length != 6))
                {
                    Console.Write("Ticket number must include 6 digits!");
                    Console.ReadLine();
                    continue;
                }

                var leftPart = int.Parse(ticketNumber?.Substring(
                    0, ticketNumber.Length / 2));
                var rightPart = int.Parse(ticketNumber?.Substring(
                    (ticketNumber.Length) / 2, ticketNumber.Length -3));

                Console.WriteLine(IsHappy(leftPart) == IsHappy(rightPart)
                    ? "You have a happy ticket!"
                    : "It is not a happy ticket :(");
                
                break;
            }

        }

        private static int IsHappy(int value)
        {
            var sum = 0;
            while (value != 0)
            {
                sum += value % 10;
                value /= 10;
            }

            return sum;
        }
    }
}