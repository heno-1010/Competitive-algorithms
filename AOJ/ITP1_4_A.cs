using System;

class Program
{
    static void Main()
    {
      string[] input = Console.ReadLine().Split(' ');
		  int a = int.Parse(input[0]);
		  int b = int.Parse(input[1]);
		  
		  int d = a / b;
		  int r = a % b;
		  double f =  (double)a / b;
		  Console.WriteLine("{0} {1} {2}", d, r, f.ToString("f5"));
    }
}
