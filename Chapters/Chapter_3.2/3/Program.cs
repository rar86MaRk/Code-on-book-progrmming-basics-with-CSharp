int hol_day = int.Parse(Console.ReadLine());
int vork_day_hour = 63;
int hol_day_hour = 127;
int normal = 30000;

int play_time = hol_day * hol_day_hour + (365 - hol_day) * vork_day_hour;

if (play_time > normal)
{
    int raz = play_time - normal;
    int hour = raz / 60;
    int min = raz - hour * 60;
    Console.WriteLine("Том сбежит.");
    Console.WriteLine(hour + " часа и " + min + " на игру");
}
else if (play_time < normal)
{
    int raz = normal - play_time;
    int hour = raz / 60;
    int min = raz - hour * 60;
    Console.WriteLine("Том выспится.");
    Console.WriteLine("На " + hour + " часа и " + min + " меньше на игру");
}
else
{
    Console.WriteLine("Eror");
}