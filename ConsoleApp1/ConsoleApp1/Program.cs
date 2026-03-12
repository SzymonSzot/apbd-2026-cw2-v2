// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input vector data (a, b, c)");
string a = Console.In.ReadLine();
Console.WriteLine("Input second vector data (a, b, c)");
string b = Console.In.ReadLine();

if (a == null || b == null)
{
    Console.WriteLine("input error");
}
