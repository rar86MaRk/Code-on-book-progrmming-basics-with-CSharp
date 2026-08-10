string val = Console.ReadLine();
var num = 0;

for (int i = 0; i < val.Length; i++)
{
    if (val[i] == 'a')
    {
        num =num + 1;
    }
    if (val[i] == 'e')
    {
        num = num + 2;
    }
    if (val[i] == 'i')
    {
        num = num + 3;
    }
    if (val[i] == 'o')
    {
        num = num + 4;
    }
    if (val[i] == 'u')
    {
        num = num + 5;
    }
}

try
{
    Console.WriteLine(num);
}
catch
{
    Console.WriteLine("Invalid number char!!!");
}
