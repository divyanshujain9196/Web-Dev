using System;

namespace Ass2_18
{
    class Program
    {
        public int sum(int a,int b)
        {
            Console.WriteLine("sum is: " + (a + b));
            Console.ReadKey();

            return 0;
        }
        static void Main(string[] args)
        {

            int a = 10, b=20;
            Program program = new Program();  
            program.sum(a,b);
        }
    }
}
