using System;

class Program
{
    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());

        double menseki = Math.PI * r * r;
        double ensyuu = 2* Math.PI * r;
        Console.WriteLine("{0} {1}", menseki.ToString("f6"), ensyuu.ToString("f6"));
    }
}
