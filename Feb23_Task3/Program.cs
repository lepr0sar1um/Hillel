using System;
using System.Linq;

namespace Feb23_Task3
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input ticket number: ");
                var ticketNumber = Console.ReadLine();
                
                if (ticketNumber == null || (ticketNumber.Length <6 || ticketNumber.Length > 6))
                {
                    Console.WriteLine("Ticket number must include 6 digits!");
                    continue;
                }

                var leftPart = int.Parse(ticketNumber?.Substring(0, ticketNumber.Length / 2));
                var rightPart = int.Parse(ticketNumber?.Substring((ticketNumber.Length) / 2, ticketNumber.Length -3));

                Console.WriteLine(IsHappy(leftPart) == IsHappy(rightPart)
                    ? "You have happy ticket!"
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