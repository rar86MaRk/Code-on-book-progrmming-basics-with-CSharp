var anim = Console.ReadLine();

switch (anim)
{
    case ("dog"):
        Console.WriteLine("mammal");
        break;
    case ("crocdile"):
    case ("tortoise"):
    case ("snake"):
        Console.WriteLine("reptile");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}