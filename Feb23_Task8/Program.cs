using System;

namespace Feb23_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var X = false;
            var Y = true;
            var Z = false;

            Console.WriteLine(X || Z);
            Console.WriteLine(X && Y);
            Console.WriteLine(X && Z);
        }
    }
}