﻿using System;

namespace codesnippet10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Even numbers");
            do
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
                num += 1;
            } while (num <= 11);
        }
    }
}
