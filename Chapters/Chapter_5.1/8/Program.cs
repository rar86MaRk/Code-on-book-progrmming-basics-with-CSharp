var n = int.Parse(Console.ReadLine());
int chet = 0;
int nechet = 0;
for (int i = 1; i <= n; i++)
{
    var p = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        chet = chet + p;
    }
    else
    {
        nechet = nechet + p;
    }
}

if (chet == nechet)
{
    Console.WriteLine("Да,сумма = "+chet);
}
else if (chet > nechet)
{
    Console.WriteLine("Нет,разность = "+(chet-nechet));
}
else if (chet < nechet)
{
    Console.WriteLine("Нет,разность = "+(nechet-chet));
}