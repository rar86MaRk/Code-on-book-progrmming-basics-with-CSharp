Console.Write("Введите часы: ");
int hour = int.Parse(Console.ReadLine());
Console.Write("Введите минуты: ");
int min = int.Parse(Console.ReadLine());
min = min + 15;
if (min > 59)
{
    hour = hour + (min / 60);
    min = min - 60;
}

if (hour > 23)
{
    hour = hour - 24;
}

if (min < 9)
{
    string g_min = "0" + min;
    Console.WriteLine(hour + ":" + g_min);
}
else
{
    Console.WriteLine(hour + ":" + min);
}