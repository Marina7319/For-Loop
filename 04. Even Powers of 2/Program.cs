﻿using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i+=2)
            { if (i % 2 == 0)
                {                
                    Console.WriteLine(Math.Pow(2,i));
                }               
            }
        }
    }
}
