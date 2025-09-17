using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);

            for (int i = 0; i < H; i++)
            {
                if (i == 0 || i == H - 1)
                {
                    Console.WriteLine(new string('#', W)); // 上下の行
                }
                else
                {
                    Console.WriteLine("#" + new string('.', W - 2) + "#"); // 中の行
                }
            }

            Console.WriteLine(); // データセットごとの空行
            if (H == 0 && W == 0)
            {
                break;
            }
        }
    }
}
