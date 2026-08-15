int n = int.Parse(Console.ReadLine());

for (int str = 1; str <= n; str++)
{
    for(int st = 1; st <= n; st++)
    {
        if ((st == 1) && (str == 1 || str == n))
        {
            Console.Write("+ ");
        }
        else if((st == 1) && (str != 1 && str != n))
        {
            Console.Write("| ");
        }
        else if ((st == n) && (str == 1 || str == n))
        {
            Console.Write(" +");
        }
        else if((st == n) && (str != 1 && str != n))
        {
            Console.Write(" |");
        }
        else
        {
            Console.Write(" - ");
        }
    }
    Console.WriteLine();
}