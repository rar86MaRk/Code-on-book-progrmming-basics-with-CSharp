var prod = Console.ReadLine().ToLower();
var town = Console.ReadLine().ToLower();
var col = double.Parse(Console.ReadLine());
if (town == "sofia")
{
    if (prod == "coffe")
    {
        Console.WriteLine(0.50 * col);
    }
    else if (prod == "voda")
    {
        Console.WriteLine(0.80 * col);
    }
    else if (prod == "pivo")
    {
        Console.WriteLine(1.20 * col);
    }
    else if (prod == "sladosti")
    {
        Console.WriteLine(1.45 * col);
    }
    else if (prod == "arahis")
    {
        Console.WriteLine(1.60 * col);
    }
}
else if (town == "plovdiv")
{
    if (prod == "coffe")
    {
        Console.WriteLine(0.40 * col);
    }
    else if (prod == "voda")
    {
        Console.WriteLine(0.70 * col);
    }
    else if (prod == "pivo")
    {
        Console.WriteLine(1.15 * col);
    }
    else if (prod == "sladosti")
    {
        Console.WriteLine(1.30 * col);
    }
    else if (prod == "arahis")
    {
        Console.WriteLine(1.50 * col);
    }
}
else if (town == "varna")
{
    if (prod == "coffe")
    {
        Console.WriteLine(0.45 * col);
    }
    else if (prod == "voda")
    {
        Console.WriteLine(0.70 * col);
    }
    else if (prod == "pivo")
    {
        Console.WriteLine(1.10 * col);
    }
    else if (prod == "sladosti")
    {
        Console.WriteLine(1.35 * col);
    }
    else if (prod == "arahis")
    {
        Console.WriteLine(1.55 * col);
    }
}