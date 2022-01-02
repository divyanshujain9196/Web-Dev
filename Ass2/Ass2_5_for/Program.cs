using System;

namespace Ass2_5_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial  is: " + fact);
            Console.ReadKey();
        }
    }
}
