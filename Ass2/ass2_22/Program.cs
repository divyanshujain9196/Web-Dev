using System;

namespace ass2_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i < 5; i++)
            {
                for (k = 5 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (j = i; j >= 1; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();


            }
        }
    }
}
