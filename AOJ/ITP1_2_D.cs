using System;
class Program
{
	static void Main(string[] args)
	{
	  string[] input = Console.ReadLine().Split(' ');
		int W = int.Parse(input[0]);
		int H = int.Parse(input[1]);
		int x = int.Parse(input[2]);
		int y = int.Parse(input[3]);
		int r = int.Parse(input[4]);
		
		int enx = x + r;
		int eny = y + r;
		if(0 <= (x-r) && x+r <= W && 0 <= (y-r) && y+r <= H && W >= x && H >= y && W >= enx && H >= eny){
		  Console.WriteLine("Yes");
		}
    else{
		  Console.WriteLine("No");
		}
	}
}
