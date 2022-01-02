using System;

namespace Ass2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, max, n;
            n = 5;
            max = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                
            }
            Console.Write("Maximum element = {0}\n", max);
            Console.ReadKey();
            
        }
    }
}
