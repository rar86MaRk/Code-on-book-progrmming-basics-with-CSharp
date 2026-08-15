Console.Write("Введите значение: ");
double value_one = double.Parse(Console.ReadLine());
Console.Write("Введите значение: ");
double value_two = double.Parse(Console.ReadLine());
Console.Write("Введите значение: ");
double value_tree = double.Parse(Console.ReadLine());

if (value_one == value_two && value_tree == value_two && value_one == value_tree)
{
    Console.WriteLine("Равны");
}
else
{
    Console.WriteLine("Не равны");
}