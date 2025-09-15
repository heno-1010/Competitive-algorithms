using System;
class Program
{
	static void Main(string[] args)
	{
		string[] input = Console.ReadLine().Split(' ');
		int a = int.Parse(input[0]);
		int b = int.Parse(input[1]);
		int c = int.Parse(input[2]);
		
		if(a <= 0 && c <= 100){
		  Console.WriteLine("No");
		}else if(a < b && b < c){
		  Console.WriteLine("Yes");
		}else{
		  Console.WriteLine("No");
		}
	}
}
