string value = Console.ReadLine().ToLower();
if (value == "banan" || value == "iabloko" || value == "kivi" || value == "vishna" || value == "limon" || value == "vinograd")
{
    Console.WriteLine("Фрукты");
}
else if (value == "pomidor" || value == "ogyrec" || value == "perec" || value == "morkov")
{
    Console.WriteLine("Овощь");
}
else
{
    Console.WriteLine("Неизвестно");
}