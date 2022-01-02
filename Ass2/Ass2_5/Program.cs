using System;

namespace Ass2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter Number: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int factorial = 1;
            do
            {
                factorial *= i;
                i++;
            }
            while (i <= n);
            Console.WriteLine("Factorial is : "+ factorial);
        
        Console.ReadKey();
        }
    }
}
