string[] input = Console.ReadLine().Split(' ');
int A = int.Parse(input[0]);
string op = input[1];
int B = int.Parse(input[2]);

if (op == "+")
{
    Console.WriteLine(A + B);
}
else if (op == "-")
{
    Console.WriteLine(A - B);
}
