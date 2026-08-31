int n = int.Parse(Console.ReadLine()!);
int num = 0;

for (int i = 0; i <= n; i++)
{
    var res = Math.Pow(2,num);

    if (num % 2 == 0)
    {
        Console.WriteLine(res);
    }

    num = num + 1;
}
