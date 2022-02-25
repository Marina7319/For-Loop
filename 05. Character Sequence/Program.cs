using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();   
            for (int q = 0; q < input.Length; q++)
            {
                Console.WriteLine(input[q]);
            }
        }
    }
}
