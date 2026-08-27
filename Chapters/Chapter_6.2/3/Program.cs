int n = int.Parse(Console.ReadLine()!);

var underScop = 2 * n + 1;
var dotVal = n + 1; 

Console.WriteLine(new string('.', dotVal) + new string('_', underScop + 4) + new string('.', dotVal));

dotVal = dotVal - 1;
underScop = underScop + 2;

for (int i = 0; i < n; i++)
{
    Console.WriteLine(new string('.', dotVal) + "//" + new string('_', underScop) + "\\\\" + new string('.', dotVal));

    dotVal = dotVal - 1;
    underScop = underScop + 2;
}

Console.WriteLine(new string('.', dotVal) + "//" + new string('_', underScop / 2 - 2) + "STOP!" + new string('_', underScop / 2 - 2) + "\\\\" + new string('.', dotVal));

for (int i = 0; i < n; i++)
{
    Console.WriteLine(new string('.', dotVal) + "\\\\" + new string('_', underScop) + "//" + new string('.', dotVal));

    dotVal = dotVal + 1;
    underScop = underScop - 2;
}