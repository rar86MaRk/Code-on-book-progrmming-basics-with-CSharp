var budzhet = double.Parse(Console.ReadLine());
var sezon = Console.ReadLine().ToLower();

if (budzhet <= 100)
{
    if (sezon == "leto")
    {
        Console.WriteLine("Где-то в Болгарий.");
        Console.WriteLine("Кампинг - "+Math.Round((budzhet * 0.3),2) + " BGN");
    }
    else if (sezon == "zima")
    {
        Console.WriteLine("Где-то в Болгарий.");
        Console.WriteLine("Отель - "+Math.Round((budzhet * 0.7),2) + " BGN");
    }
    else
    {
        Console.WriteLine("Error-1");
    }
}
else if (budzhet <= 1000 && budzhet > 100)
{
    if (sezon == "leto")
    {
        Console.WriteLine("Где-то на Балканах.");
        Console.WriteLine("Кампинг - "+Math.Round((budzhet * 0.4),2) + " BGN");`
    }
    else if (sezon == "zima")
    {
        Console.WriteLine("Где-то в Балканах.");
        Console.WriteLine("Отель - "+Math.Round((budzhet * 0.8),2) + " BGN");
    }
    else
    {
        Console.WriteLine("Error-1");
    }
}
else if (budzhet > 1000)
{
    Console.WriteLine("Где-то в Европе.");
    Console.WriteLine("Отель - "+Math.Round((budzhet * 0.9),2) + " BGN");
}
else
{

}