string mes = Console.ReadLine().ToLower();
int day = int.Parse(Console.ReadLine());

decimal studioPrice = 0.0M;
decimal apartamentPrice = 0.0M;

decimal studioRent = 0.0M;
decimal apartamentRent = 0.0M;


switch (mes)
{
    case "may":
    case "october":
        studioPrice = 50.00M;
        apartamentPrice = 65.00M;

        studioRent = studioPrice * day;
        apartamentRent = apartamentPrice * day;

        if (day > 14)
        {
            studioRent *= 0.70M;
            apartamentRent *= 0.90M;
        }
        else if (day > 7)
        {
            studioRent = studioRent * 0.95M;
        }
    

        break;
    case "june":
    case "september":
        studioPrice = 75.20M;
        apartamentPrice = 68.70M;

        studioRent = studioPrice * day;
        apartamentRent = apartamentPrice * day;

        if (day > 14)
        {
            studioRent *= 0.80M;
            apartamentRent *= 0.90M;
        }

        break;
    case "july":
    case "august":
        studioPrice = 76.00M;
        apartamentPrice = 77.00M;

        studioRent = studioPrice * day;
        apartamentRent = apartamentPrice * day;

        if (day > 14)
        {
            apartamentRent *= 0.90M;
        }

        break;
}

Console.WriteLine("Аппартаменты: "+ decimal.Round(apartamentRent,2) +" lv");
Console.WriteLine("Студия: "+ decimal.Round(studioRent,2) +" lv");
