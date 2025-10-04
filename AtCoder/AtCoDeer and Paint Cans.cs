using System;
using System.Collections.Generic;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            var list = new HashSet<int>() {a,b,c};
            Console.WriteLine(list.Count);
        }
    }
}