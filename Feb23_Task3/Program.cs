using System;

namespace Feb23_Task3
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var ticket = new TicketOptions();
            ticket.ParseTicketNumber();
        }
    }
}