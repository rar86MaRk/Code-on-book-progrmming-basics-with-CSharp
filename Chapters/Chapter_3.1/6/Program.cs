Console.Write("Введите название  фигуры на латинеце: ");
string input_figure = Console.ReadLine();

if (input_figure == "kvadrat")
{
    Console.Write("Введите длину стороны квадрата: ");
    double input_kvadrat = double.Parse(Console.ReadLine());
    input_kvadrat = input_kvadrat * input_kvadrat;
    Console.WriteLine("Площадь квадрата: "+input_kvadrat );
}
else if (input_figure == "pramoygolnik")
{
    Console.Write("Введите длину: ");
    double input_pruam_one = double.Parse(Console.ReadLine());
    Console.Write("Введите высоту: ");
    double input_pruam_two = double.Parse(Console.ReadLine());
    input_pruam_one = input_pruam_one * input_pruam_two;
    Console.WriteLine("Площадь прямоугольника: "+input_pruam_one);
}
else if (input_figure == "krug")
{
    Console.Write("Введите радиус: ");
    double input_krug = double.Parse(Console.ReadLine());
    input_krug = input_krug * input_krug;
    input_krug = input_krug *   3.14;
    Console.WriteLine("Площадь круга: "+input_krug);
}
else if (input_figure == "treugolnik")
{
    Console.Write("Введите длину основы: ");
    double input_treug_osn = double.Parse(Console.ReadLine());
    Console.Write("Введите высоту: ");
    double input_treug_vis = double.Parse(Console.ReadLine());
    input_treug_osn = input_treug_osn * input_treug_vis * 0.5;
    Console.WriteLine("Площадь треугольника: "+input_treug_osn);
}
else
{
    Console.WriteLine("Eror");
}