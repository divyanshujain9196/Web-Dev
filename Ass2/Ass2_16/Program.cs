using System;

namespace Ass2_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 4 numbers to swap");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            // swapping b and c variables
            b = b + c;
            c = b - c;
            b = b - c;

            // swapping c and d variables
            c = c + d;
            d = c - d;
            c = c - d;

            Console.WriteLine("After swapping :");
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
            Console.WriteLine("c= " + c);
            Console.WriteLine("d= " + d);
            Console.ReadKey();

        }
    }
}
