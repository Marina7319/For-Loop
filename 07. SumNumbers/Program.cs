using System;

namespace _07._SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 0; i < numOne; i++)
            {
                int numTwo = int.Parse(Console.ReadLine());
                result += numTwo;
            }
            Console.WriteLine(result);
        }
    }
}
