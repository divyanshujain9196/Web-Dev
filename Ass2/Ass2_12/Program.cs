using System;

namespace Ass2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, min, n;
          
            n = 5;
            min = arr[0];
            for (i = 1; i < n; i++)
            {
               
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            
            Console.Write("Minimum element = {0}\n\n", min);
            Console.ReadKey();
        }
    }
}
