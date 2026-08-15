int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("* ");
    for (int t = 1; t < n; t++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
