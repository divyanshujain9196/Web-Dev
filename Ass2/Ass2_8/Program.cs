using System;

namespace Ass2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            double first, second, result;

            Console.Write("Enter first number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            op = (char)Console.Read();

            switch (op)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine(result);
                    break;

                case '-':
                    result = first - second;
                    Console.WriteLine(result);
                    break;

                case '*':
                    result = first * second;
                    Console.WriteLine(result);
                    break;

                case '/':
                    result = first / second;
                    Console.WriteLine( result);
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;

            }
            Console.ReadKey();
        }
    }
}
