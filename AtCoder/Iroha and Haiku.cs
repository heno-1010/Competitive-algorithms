using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            int five = 0;
            int seven = 0;

            for (int n = 0; n < input.Length; n++)
            {
                if (input[n].Contains("5"))
                {
                    five++;
                }
                else if (input[n].Contains("7"))
                {
                    seven++;
                }
            }

            if(five == 2 && seven == 1){
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
    }