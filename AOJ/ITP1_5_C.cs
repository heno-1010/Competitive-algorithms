using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true) {
            string[] input = Console.ReadLine().Split(' ');
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);
            if (H == 0 && W == 0)
            {
                break;
            }

            for (int i = 0; i < H; i++) {
                for (int j = 0; j < W; j++)
                {
                    if ((i + j)  % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
    }
}
