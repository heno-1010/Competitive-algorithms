using System;
class Program
{
	static void Main(string[] args)
	{
		string[] input = Console.ReadLine().Split(' ');
		int a = int.Parse(input[0]);
		int b = int.Parse(input[1]);
		
		if(a == b){
		  Console.WriteLine("a == b");
		}else if(a < b){
		  Console.WriteLine("a < b");
		}else{
		  Console.WriteLine("a > b");
		}
	}
}
