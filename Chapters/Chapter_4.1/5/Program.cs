var x1 = int.Parse(Console.ReadLine());
var y1 = int.Parse(Console.ReadLine());
var x2 = int.Parse(Console.ReadLine());
var y2 = int.Parse(Console.ReadLine());
var x = int.Parse(Console.ReadLine());
var y = int.Parse(Console.ReadLine());

if (((x >= x1 && x <= x2) && (y == y1 || y == y2))||(( y >= y1 && y <= y2) && (x == x1 || x == x2)))
{
    Console.WriteLine("Граница");
}
else
{
    Console.WriteLine("Внутри/Снаружи");
}