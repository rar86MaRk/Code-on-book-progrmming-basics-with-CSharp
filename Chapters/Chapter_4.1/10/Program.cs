string type = Console.ReadLine().ToLower();
int rad = int.Parse(Console.ReadLine());
int mesto = int.Parse(Console.ReadLine());
int sale = 0;
int mesta = rad * mesto;


switch (type)
{
    case ("prem"):
        Console.WriteLine(mesta * 12);
        break;
    case ("standart"):
        Console.WriteLine(mesta * 7.50);
        break;
    case ("skidka"):
        Console.WriteLine(mesta * 5);
        break;
}