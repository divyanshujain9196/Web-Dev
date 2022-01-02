using System;

namespace Ass2_20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j.ToString());
                Console.WriteLine();
            }
        }
    }
}
