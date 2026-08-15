Console.Write("Введите значение:");
double input = double.Parse(Console.ReadLine());
Console.Write("Введите входную единицу: ");
string input_char = Console.ReadLine().ToLower();
Console.Write("Введите выходную единицу: ");
string output_char = Console.ReadLine().ToLower();

if (input_char == "mm")
{
    input = input / 1000;
}
if (input_char == "cm")
{
    input = input / 100;
}
if (input_char == "mi")
{
    input = input / 0.000621371192;
}
if (input_char == "km")
{
    input = input / 0.001;
}
if (input_char == "ft")
{
    input = input / 3.2808399;
}
if (input_char == "yd")
{
    input = input / 1.0936133;
}
else
{
}

if (output_char == "mm")
{
    input = input * 1000;
}
if (output_char == "cm")
{
    input = input * 100;
}
if (output_char == "mi")
{
    input = input * 0.000621371192;
}
if (output_char == "km")
{
    input = input * 0.001;
}
if (output_char == "ft")
{
    input = input * 3.2808399;
}
if (output_char == "yd")
{
    input = input * 1.0936133;
}
else
{
}

Console.WriteLine("Результат: "+input);