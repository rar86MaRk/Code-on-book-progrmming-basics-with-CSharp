Console.Write("Введите значение: ");
double input_char = double.Parse(Console.ReadLine());

if (input_char < 100)
{
    Console.WriteLine("Менее 100");
}
else if (input_char > 100 && input_char < 200)
{
    Console.WriteLine("От 100 до 200");
}
else if (input_char > 200)
{
    Console.WriteLine("Более 200");
}
else
{
    Console.WriteLine("Eror");
}