int ekzamen_hour = int.Parse(Console.ReadLine());
int ekzamen_min = int.Parse(Console.ReadLine());
int ych_hour = int.Parse(Console.ReadLine());
int ych_min = int.Parse(Console.ReadLine());

int time_ekz = (ekzamen_hour * 60) + ekzamen_min;
int ych_time = (ych_hour * 60) + ych_min;

if (time_ekz == ych_time)
{
    Console.WriteLine("Вовремя");
}
else if (time_ekz >= ych_time && (time_ekz - 30) <= ych_time)
{
    Console.WriteLine("Вовремя, за " + (time_ekz - ych_time) + " до начала.");
}
else if ((time_ekz - ych_time) >= 30)
{
    if ((time_ekz - ych_time) - (((time_ekz - ych_time) / 60) * 60) > 9)
    {
        Console.WriteLine("Рано,за " + ((time_ekz - ych_time) / 60) + ":" + ((time_ekz - ych_time) - (((time_ekz - ych_time) / 60) * 60)) + " до начала.");
    }
    else if ((time_ekz - ych_time) - (((time_ekz - ych_time) / 60) * 60) <= 9)
    {
        Console.WriteLine("Рано,за " + ((time_ekz - ych_time) / 60) + ":0" + ((time_ekz - ych_time) - (((time_ekz - ych_time) / 60) * 60)) + " до начала.");
    }
}
else if ((ych_time - time_ekz) < 60 && (ych_time - time_ekz) != 0)
{
    Console.WriteLine("Опоздал," + (ych_time - time_ekz) + " после начала.");
}
else if ((ych_time - time_ekz) > 60)
{
    if ((ych_time - time_ekz) - (((ych_time - time_ekz) / 60) * 60) > 9)
    {
        Console.WriteLine("Опоздал, " + ((ych_time - time_ekz) / 60) + ":" + ((ych_time - time_ekz) - (((ych_time - time_ekz) / 60) * 60)) + " после начала.");
    }
    else if ((ych_time - time_ekz) - (((ych_time - time_ekz) / 60) * 60) <= 9)
    {
        Console.WriteLine("Опоздал, " + ((ych_time - time_ekz) / 60) + ":0" + ((ych_time - time_ekz) - (((ych_time - time_ekz) / 60) * 60)) + " после начала.");
    }
}
