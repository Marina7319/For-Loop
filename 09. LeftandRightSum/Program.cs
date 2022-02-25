using System;

namespace _09._LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int NNums = int.Parse(Console.ReadLine());
            double resultOne = 0;
            double resultTwo = 0;
            for (int i = 1; i <= NNums; i++)
            {
                int numOneTwo = int.Parse(Console.ReadLine());
                resultOne += numOneTwo;
     
            }
            for( int ii = 1; ii <= NNums; ii++)
            {
                int numTreeFour = int.Parse(Console.ReadLine());
                resultTwo += numTreeFour;
            }
            if(resultOne == resultTwo)
            {
                double number =( resultOne = resultTwo);
                Console.WriteLine("Yes, sum = " + number);
            }
            else
            {
                double difference = Math.Abs(resultOne - resultTwo);
                Console.WriteLine("No, diff = " + difference);
            }
        }
    }
}
