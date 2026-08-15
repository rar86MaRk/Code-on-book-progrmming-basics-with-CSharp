int n = int.Parse(Console.ReadLine());
string day_or_night = Console.ReadLine();
double pirce = 0;

if (day_or_night == "day")
{
    if (n > 20 && n < 100)
    {
        pirce = 0.09 * n;
    }
    else if (n > 100)
    {
        pirce = 0.06 * n;
    }
    else if (n < 20)
    {
        pirce = 0.79 * n + 0.70;
    }
}
else if (day_or_night == "night")
{
    if (n > 20 && n < 100)
    {
        pirce = 0.09 * n;
    }
    else if (n > 100)
    {
        pirce = 0.06 * n;
    }
    else if (n < 20)
    {
        pirce = 0.90 * n + 0.70;
    }
}

Console.WriteLine(pirce);