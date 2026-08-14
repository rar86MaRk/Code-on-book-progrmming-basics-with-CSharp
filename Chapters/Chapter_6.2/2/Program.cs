int n = int.Parse(Console.ReadLine()!);

int halfN = n - 2;

for (int i = 1; i <= halfN; i++)
{
    if(i % 2 != 0){Console.WriteLine(new string('*', halfN) + "\\ /" + new string('*', halfN));}else{Console.WriteLine(new string('-', halfN) + "\\ /" + new string('-', halfN));}
}

Console.WriteLine(new string(' ',halfN + 1) + '@');

for (int i = 1; i <= halfN; i++)
{
    if(i % 2 != 0){Console.WriteLine(new string('*', halfN) + "/ \\" + new string('*', halfN));}else{Console.WriteLine(new string('-', halfN) + "/ \\" + new string('-', halfN));}
}