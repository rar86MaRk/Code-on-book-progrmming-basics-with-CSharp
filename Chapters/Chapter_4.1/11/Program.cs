string year = Console.ReadLine().ToLower();
var hollidays = double.Parse(Console.ReadLine());
var h_to_life_city = double.Parse(Console.ReadLine());

double SofiaW = 48 - h_to_life_city;
double play_in_sofia = (((SofiaW / 4) * 3)) + ((hollidays / 3) * 2);
double playTotal = h_to_life_city + play_in_sofia;

if (year == "leap")
{
    playTotal = Math.Floor(((playTotal / 100) * 15) + playTotal);
}
else if (year == "normal")
{
    playTotal = Math.Floor(playTotal);
}
Console.WriteLine(playTotal);