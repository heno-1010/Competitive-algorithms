using System;
class Program
{
	static void Main(string[] args)
	{
    int[] numbers = {0, 1, 2};
    string[] input = Console.ReadLine().Split(' ');
		int a = int.Parse(input[0]);
		int b = int.Parse(input[1]);
		int c = int.Parse(input[2]);
		numbers[0] = a;
		numbers[1] = b;
		numbers[2] = c;
		
    Array.Sort(numbers);
    Console.WriteLine(string.Join(" ", numbers));
	}
}
