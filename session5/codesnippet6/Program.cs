﻿using System;

namespace codesnippet6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dimesion = new int[4, 5];
            int numOne = 0;
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dimesion[i, j] = numOne;
                    numOne++;
                }
            }
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(dimesion[i, j] + "");
                }
                Console.Write(dimesion[i, j] + "");

            }
            Console.WriteLine();
        }
    }
}
