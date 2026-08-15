decimal budzhet = decimal.Parse(Console.ReadLine());
string type = Console.ReadLine();
var value_people = int.Parse(Console.ReadLine());
decimal costTransfer = 0;

if (value_people <= 4)
{
    costTransfer = 0.75M * budzhet;
}
else if (value_people >= 5 && value_people <= 9)
{
    costTransfer = 0.60M * budzhet;
}
else if (value_people >= 10 && value_people <= 24)
{
    costTransfer = 0.50M * budzhet;
}
else if (value_people >= 25 && value_people <= 49)
{
    costTransfer = 0.40M * budzhet;
}
else if (value_people >= 50)
{
    costTransfer = 0.25M * budzhet;
}

budzhet = budzhet - costTransfer;
decimal costTicket = 0;

switch (type)
{
    case "VIP":
        costTicket = value_people * 499.99M;
        break;
    case "Normal":
        costTicket = value_people * 249.99M;
        break;
    default:
        costTicket = value_people * 249.99M;
        break;
}

if (costTicket <= budzhet)
{
    Console.WriteLine("Хватает, у вас осталось " + (budzhet - costTicket) + " лева.");
}
else if (costTicket > budzhet)
{
    Console.WriteLine("Нехватает, ещй нужно "+(costTicket - budzhet)+" лева.");
}
