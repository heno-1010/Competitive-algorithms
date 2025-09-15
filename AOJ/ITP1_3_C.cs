using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int x, y;
            string[] input = Console.ReadLine().Split();
            x = int.Parse(input[0]);
            y = int.Parse(input[1]);

            if (x == 0 && y == 0){
              break;
            }
            if (x < y){
              Console.WriteLine($"{x} {y}");
            }else{
              Console.WriteLine($"{y} {x}");
            }

        }
    }
}
