var age = double.Parse(Console.ReadLine());
var gen = Console.ReadLine();

if (gen == "f")
{
    if (age < 16)
    {
        Console.WriteLine("Miss");
    }
    else
    {
        Console.WriteLine("Ms.");
    }
}
else if (gen == "m")
{
    if (age < 16)
    {
        Console.WriteLine("Master");
    }
    else
    {
        Console.WriteLine("Mr.");
    }
}