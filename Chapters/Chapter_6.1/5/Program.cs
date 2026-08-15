int n = int.Parse(Console.ReadLine());
int otstup = n;
int otstup2 = 1;

for (int i = 1; i <= n; i++)
{
    Console.Write(new string(' ',otstup));
    for (int y = 1; y < i; y++)
    {
        Console.Write(" * ");
    }
    otstup = otstup - 1;
    Console.WriteLine();
}

for (int y = 0; y < n; y++)
{
    Console.Write(" * ");
}
Console.WriteLine();

for (int i = 1; i < n; i++)
{
    Console.Write(new string(' ',otstup2));
    for (int y = (n-1); y >= i; y--)
    {
        Console.Write(" * ");
    }
    otstup2 = otstup2 + 1;
    Console.WriteLine();
}