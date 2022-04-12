using System;
namespace FactorialByRecursion
{
    class program
    {
        static void Main(string[] args)
        {
            FactorialByRecursion factorial = new FactorialByRecursion();
            int answer = factorial.Recursion();
            Console.WriteLine("Factorial of given number "+ answer);
            Console.ReadLine();
        }
    }
}