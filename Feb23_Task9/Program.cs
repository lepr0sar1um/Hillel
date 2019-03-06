using System;

namespace Feb23_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var X = false;
            var Y = false;
            var Z = true;

            Console.WriteLine(X || Y && !Z);
            Console.WriteLine(!X && !Y);
            Console.WriteLine(!(X && Z) || Y);
            Console.WriteLine(X && !Y || Z);
            Console.WriteLine(X && (!Y || Z));
            Console.WriteLine(X && (!(Y || Z)));
        }
    }
}