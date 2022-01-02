using System;

namespace Ass2_5_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1, i = 1;
            while(i<=n)
            {
                fact = fact * i;
                i++;

            }
            Console.WriteLine("Fcatorial is " + fact);
            Console.ReadKey();
            
        }
        
    }
}
