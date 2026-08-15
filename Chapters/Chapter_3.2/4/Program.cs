Console.Write("Введите площадь виноградника: ");
var squad_vin = int.Parse(Console.ReadLine());
Console.Write("Введите КГ винограда с 1 м.квад.: ");
var vin_for_one_squad = double.Parse(Console.ReadLine());
Console.Write("Введите нужное количество Л. винограда: ");
var win_squad_vin = int.Parse(Console.ReadLine());
Console.Write("Введите колличество рабочих: ");
var work_pep = int.Parse(Console.ReadLine());

var ril_vingrad = squad_vin * vin_for_one_squad / 100 * 40;
ril_vingrad = ril_vingrad / 2.5;


if (ril_vingrad > win_squad_vin)
{
    Console.WriteLine("Хороший урожай в этом году! Общий объём вина: " + Math.Floor(ril_vingrad)+" Осталось " + Math.Floor(ril_vingrad-win_squad_vin)+" литра -> "+Math.Floor((ril_vingrad-win_squad_vin) / work_pep)+" литров на человека.");
}
else if (ril_vingrad < win_squad_vin)
{
    Console.WriteLine("Это будет суровая зима! Нужно ещё " + Math.Floor(win_squad_vin - ril_vingrad) + " литров вина.");
}
