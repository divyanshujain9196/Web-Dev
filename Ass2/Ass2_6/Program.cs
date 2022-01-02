using System;

namespace Ass2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int table = 1; table <= 10; table++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(table + " * " + (i) + " = " + (table * (i)));
                }
                Console.WriteLine("----------");
            }
        }
    }
}
