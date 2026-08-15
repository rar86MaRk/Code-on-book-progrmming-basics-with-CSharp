using System.Globalization;
using System.Text.RegularExpressions;

decimal n1 = int.Parse(Console.ReadLine());
var d = Console.ReadLine();
decimal n2 = int.Parse(Console.ReadLine());

if (d == "+")
{
    var val = n1 + n2;
    if (val % 2 == 0)
    {
        Console.WriteLine(n1 + "+" + n2 + "=" + val + "(Чётное)");
    }
    else
    {
        Console.WriteLine(n1 + "+" + n2 + "=" + val + "(Нечётное)");
    }
}
else if (d == "-")
{
    var val = n1 - n2;
    if (val % 2 == 0)
    {
        Console.WriteLine(n1 + "-" + n2 + "=" + val + "(Чётное)");
    }
    else
    {
        Console.WriteLine(n1 + "-" + n2 + "=" + val + "(Нечётное)");
    }
}
else if (d == "/")
{
    var val = n1 / n2;
    Console.WriteLine(n1 + "/" + n2 + "=" + val);

}
else if (d == "*")
{
    var val = n1 * n2;
    if (val % 2 == 0)
    {
        Console.WriteLine(n1 + "*" + n2 + "=" + val + "(Чётное)");
    }
    else
    {
        Console.WriteLine(n1 + "*" + n2 + "=" + val + "(Нечётное)");
    }
}
else if (d == "%")
{
    var val = n1 % n2;
    Console.WriteLine(n1+"%"+n2+"="+val);
    
}