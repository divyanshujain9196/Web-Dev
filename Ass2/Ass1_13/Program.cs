using System;

namespace Ass1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, x, y, lcm = 0;
           
            Console.WriteLine("Enter first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = int.Parse(Console.ReadLine());
            x = num1;
            y = num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            lcm = (x * y) / num1;
            Console.Write("Least Common Multiple is : " + lcm);
            Console.ReadKey();

        }
    }
}
