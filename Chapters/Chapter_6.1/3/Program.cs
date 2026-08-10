int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++ )
{
    Console.Write("$");
    for(int v = 1; v < i; v++)
    {
        Console.Write(" $");
    }
    Console.WriteLine();                                
}