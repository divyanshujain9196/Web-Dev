using System;

namespace Ass2_10
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // set the value of the three numbers
            Console.WriteLine("enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }
}
