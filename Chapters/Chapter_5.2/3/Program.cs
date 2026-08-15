double nasledstvo = double.Parse(Console.ReadLine());
double start_nas = nasledstvo;
int year = int.Parse(Console.ReadLine());
int vozrast = 18;

for (int i = 1800; i <= year; i++)
{
    if(i % 2 == 0)
    {
        nasledstvo = nasledstvo - 12000;
        vozrast = vozrast + 1;
    }
    else if(i % 2 == 1)
    {
        nasledstvo = nasledstvo - (12000 + (50 * vozrast));
        vozrast = vozrast + 1;
    }
}

if (nasledstvo == 0 || nasledstvo < 0)
{
    Console.WriteLine("Нет! Что-бы ему выжить потребуется "+((start_nas - nasledstvo) - start_nas)+" доллров.");
}
else if(nasledstvo > 0)
{
    Console.WriteLine("Да! У него останется "+nasledstvo+" доллров.");
}
