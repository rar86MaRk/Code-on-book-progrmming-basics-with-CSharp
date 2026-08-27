int n = int.Parse(Console.ReadLine()!);

int outDots = (n - 1) / 2;
int inDots = n - 2;

Console.WriteLine(new string('.',outDots) + new string('#',n) + new string('.',outDots));

for(int i = 0; i < (n - 2); i++)
{
    Console.WriteLine(new string('.',outDots) + '#' + new string('.',inDots) + '#' + new string('.',outDots));
}

Console.WriteLine(new string('#',outDots+1) + new string('.',inDots) + new string('#',outDots+1));

outDots = 1;
inDots = 2 * n - 5;

for(int i = 0; i < (n - 2); i++)
{
    Console.WriteLine(new string('.',outDots) + '#' + new string('.',inDots) + '#' + new string('.',outDots));

    outDots = outDots + 1;
    inDots = inDots - 2;
}

Console.WriteLine(new string('.',n - 1) + '#' + new string('.',n - 1));