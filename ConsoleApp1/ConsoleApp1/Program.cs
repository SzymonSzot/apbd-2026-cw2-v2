// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input vector data (a, b, c)");
string a = Console.In.ReadLine();
Console.WriteLine("Input second vector data (a, b, c)");
string b = Console.In.ReadLine();

if (a == null || b == null)
{
    Console.WriteLine("input error");
}

a = a.Replace(" ", "");
b = b.Replace(" ", "");

Console.WriteLine(a);
Console.WriteLine(b);

Double CalculateAverage(int[] values)
{
    Double sum = 0;
    foreach (int val in values)
    {
        sum += val;
    }
    return sum / values.Length;
}

Console.WriteLine(CalculateAverage(new []{1, 2, 3}));

int CalculateMax(int[] values)
{
    int max = 0;
    foreach (int val in values)
    {
        if (val > max) max = val;
    }
    return max;
}