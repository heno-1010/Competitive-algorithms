using System;

class Program
{
    static void Main()
    {
      string[] input = Console.ReadLine().Split(' ');
		  int a = int.Parse(input[0]);
		  int b = int.Parse(input[1]);
		  int c = int.Parse(input[2]);
		  
		  int count = 0;
		  
		  for(int i = a; i <= b; i++){
		    if(c % i == 0){
		      count++;
		    }
		  }
		  Console.WriteLine(count);
    }
}
