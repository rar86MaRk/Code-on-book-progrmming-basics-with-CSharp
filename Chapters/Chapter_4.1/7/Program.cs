var tow = Console.ReadLine();
var s = double.Parse(Console.ReadLine());
double comic = 0;
if (tow == "sofia")
{
    if (0 <= s && s <= 500)
    {
        comic = 0.05;
    }
    else if (500 < s && s <= 1000)
    {
        comic = 0.07;
    }
    else if (1000 < s && s <= 10000)
    {
        comic = 0.08;
    }
    else if (s > 10000)
    {
        comic = 0.12;
    }
    else
    {
        Console.WriteLine("Eror-1.1");
    }
}
else if (tow == "varna")
{
    if (0 <= s && s <= 500)
    {
        comic = 0.045;
    }
    else if (500 < s && s <= 1000)
    {
        comic = 0.075;
    }
    else if (1000 < s && s <= 10000)
    {
        comic = 0.10;
    }
    else if (s > 10000)
    {
        comic = 0.13;
    }
    else
    {
        Console.WriteLine("Eror-1.2");
    }
}
else if (tow == "plovdiv")
{
    if (0 <= s && s <= 500)
    {
        comic = 0.055;
    }
    else if (500 < s && s <= 1000)
    {
        comic = 0.08;
    }
    else if (1000 < s && s <= 10000)
    {
        comic = 0.12;
    }
    else if (s > 10000)
    {
        comic = 0.145;
    }
    else
    {
        Console.WriteLine("Eror-1.3");
    }
}
else
{
    Console.WriteLine("Eror-2");
}
if (comic >= 0 && comic != -0)
{
    Console.WriteLine(s*comic);
}
else
{
    Console.WriteLine("Eror-3");
}