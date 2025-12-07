using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string AtCoder = input[0];
            string S = input[1];
            string Contest = input[2];
            Console.WriteLine(AtCoder.Substring(0,1) + S.Substring(0, 1) + Contest.Substring(0, 1));
        }
    }
}