﻿using System;

namespace _03._Numbers_1N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {         
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i <=N; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
