using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<double> doubles = new List<double> {};
        string[] input = Console.ReadLine().Split(' ');
        for (int a = 1; a <= n; a++)
        {
            doubles.Add(int.Parse(input[a - 1]));
        }
        Console.WriteLine("{0} {1} {2}", doubles.Min(), doubles.Max(), doubles.Sum());
    }
}
