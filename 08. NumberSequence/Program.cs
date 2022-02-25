using System;

namespace _08._NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;
            int NCount = int.Parse(Console.ReadLine());
            //чете N брой цели числа 
            int numMax = int.MinValue;
            int numMin = int.MaxValue;
            double result = 0;
            //изчислява най-голямото и най-малкото от тях
                for (int i = 1; i <= NCount; i++)
                {
                numbers = int.Parse(Console.ReadLine());
                result += numbers;
                    if (numbers > numMax)
                    {
                        numMax = numbers;
                    }
                    if (numbers < numMin)
                    {
                        numMin = numbers;
                    }
                }                     
            Console.WriteLine("Max number: "+numMax);
            Console.WriteLine("Min number: "+numMin); 
        }
    }
}
