Console.Write("Введите значение: ");
double input_value = double.Parse(Console.ReadLine());

if (input_value <= 10)
{
    Console.WriteLine("Медленная");
}
else if (input_value > 10 && input_value <= 50)
{
    Console.WriteLine("Средняя");
}
else if (input_value > 50 && input_value <= 150)
{
    Console.WriteLine("Быстрая");
}
else if (input_value > 150 && input_value <= 1000)
{
    Console.WriteLine("Сверх быстрая");
}
else if (input_value > 1000)
{
    Console.WriteLine("Черезвычайно быстрая");
}
else
{
    Console.WriteLine("eror");
}