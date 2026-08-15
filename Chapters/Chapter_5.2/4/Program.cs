int TimePer = int.Parse(Console.ReadLine());
List<int> pacient = new List<int>();
int vilech = 0;
int otprav = 0;
int doc = 7;
int day = 1;

for(int i = 0; i < TimePer; i++)
{
    int pacient_one_day = int.Parse(Console.ReadLine());
    pacient.Add(pacient_one_day);
}

for(int i = 0; i < TimePer; i++)
{
    if (pacient[i] <= doc)
    {
        vilech = vilech + pacient[i];
        day = day + 1;
    }
    else
    {
        vilech = vilech + doc;
        otprav = otprav + (pacient[i]-doc);
        day = day + 1;
    }

    if(day % 3 == 0)
    {
        if(otprav > vilech)
        {
            doc = doc + 1;
        }
    }
}

Console.WriteLine("Пролеченые пациенты: " + vilech);
Console.WriteLine("Непролеченые пациенты: " + otprav);

