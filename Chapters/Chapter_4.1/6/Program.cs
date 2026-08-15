string fruts = Console.ReadLine().ToLower();
string day = Console.ReadLine().ToLower();
double num = double.Parse(Console.ReadLine());

if (day == "sunday" || day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday")
{
    if (fruts == "banan")
    {
        Console.WriteLine(num * 2.50);
    }
    else if (fruts == "iabloko")
    {
        Console.WriteLine(num * 1.20);
    }
    else if (fruts == "apelsin")
    {
        Console.WriteLine(num * 0.85);
    }
    else if (fruts == "grepfrut")
    {
        Console.WriteLine(num * 1.45);
    }
    else if (fruts == "kivi")
    {
        Console.WriteLine(num * 2.70);
    }
    else if (fruts == "ananas")
    {
        Console.WriteLine(num * 5.50);
    }
    else if (fruts == "vinograd")
    {
        Console.WriteLine(num * 3.85);
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}
else if (day == "friday" || day == "saturday")
{
    if (fruts == "banan")
    {
        Console.WriteLine(num * 2.70);
    }
    else if (fruts == "iabloko")
    {
        Console.WriteLine(num * 1.25);
    }
    else if (fruts == "apelsin")
    {
        Console.WriteLine(num * 0.90);
    }
    else if (fruts == "grepfrut")
    {
        Console.WriteLine(num * 1.60);
    }
    else if (fruts == "kivi")
    {
        Console.WriteLine(num * 3.00);
    }
    else if (fruts == "ananas")
    {
        Console.WriteLine(num * 5.60);
    }
    else if (fruts == "vinograd")
    {
        Console.WriteLine(num * 4.20);
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}
else
{
    Console.WriteLine("Eror");
}