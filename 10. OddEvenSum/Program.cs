using System;

namespace _10._OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double resultEven = 0;
            double resultOdd = 0;
            for (int i = 0; i < num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    resultEven += numbers;
                }
                if (i % 2 == 1)
                {
                    resultOdd += numbers;
                }
            }
            if (resultEven == resultOdd)
            {
                double equal = resultEven = resultOdd;
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + equal);
            }
            else
            {
                double difference = Math.Abs(resultEven - resultOdd);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + difference);
            }
        }
    }
}
