int n = int.Parse(Console.ReadLine());
int otstup = n;

Console.Write(new string(' ',n+1));
Console.Write(" | ");
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    Console.Write(new string(' ',n - i));
    for (int y = 0; y <= i; y++)
    {
        Console.Write("*");
    }
    Console.Write(" | ");
    for (int y = 0; y <= i; y++)
    {
        Console.Write("*");
    }
    otstup = otstup - 1;
    Console.WriteLine();
}
