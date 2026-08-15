var n = int.Parse(Console.ReadLine());
var plus = 0;
var plus2 = 0;
for (int z = 1; z <= n; z++)
{
    int num = int.Parse(Console.ReadLine());
    plus = plus + num;
}
for (int c = 1; c <= n; c++)
{
    int num = int.Parse(Console.ReadLine());
    plus2 = plus2 + num;
}

if (plus == plus2)
{
    Console.WriteLine("Да,сумма = " + plus);
}
else if (plus < plus2)
{
    Console.WriteLine("Нет,разница = " + (plus2 - plus));
}
else if (plus > plus2)
{
    Console.WriteLine("Нет,разница = " + (plus - plus2));
}
