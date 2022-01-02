using System;

namespace Ass2_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle");
            float r = float.Parse(Console.ReadLine());
            double area = 3.14 * r * r;
            Console.WriteLine("Area is: " + area);
            Console.ReadKey();
        }
    }
}
