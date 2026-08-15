int n = int.Parse(Console.ReadLine());

Console.WriteLine(new string('*',n*2) + new string(' ',n) + new string('*',n*2));
for (int i = 0; i <= (n-2); i++)
{
    if(i == (n-2))
    {
        Console.WriteLine(new string('*',n*2) + new string(' ',n) + new string('*',n*2));
    }
    else if((i + 2) == n - (n / 2))
    {
        Console.WriteLine(('*' + new string('/',((n*2)-2)) + '*') + new string('|',n) + ('*' + new string('/',((n*2)-2)) + '*'));
    }
    else
    {
        Console.WriteLine(('*' + new string('/',((n*2)-2)) + '*') + new string(' ',n) + ('*' + new string('/',((n*2)-2)) + '*'));
    }
}