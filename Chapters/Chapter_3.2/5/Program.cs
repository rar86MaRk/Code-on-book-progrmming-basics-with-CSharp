var hour_work =  int.Parse(Console.ReadLine());
var day_work =  int.Parse(Console.ReadLine())*0.9;
var work_pep = int.Parse(Console.ReadLine());
var sveruroch = day_work * (work_pep * 2);
var hour = Math.Floor(((day_work * 8 * work_pep + sveruroch)));
if (hour < hour_work)
{
    Console.WriteLine("Недостатачно времени! Требуется "+(hour_work-hour)+" часа.");
}
else if (hour > hour_work)
{
    Console.WriteLine("Да! Осталось "+(hour-hour_work)+" часов.");
}
else
{
    Console.WriteLine("Eror");
}

