var n = int.Parse(Console.ReadLine());
var max = -10000000000000;
for (int i = 0; i < n; i++)
{
    var num = int.Parse(Console.ReadLine());
    if (max < num)
    {
        max = num;
    }
}
Console.WriteLine(max);