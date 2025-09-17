using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int count = 0;

            for (int m = 1; m <= N; m++)
            {
                count += m;
            }
            Console.WriteLine(count);
        }
    }
}