var uchsnik_1 = double.Parse(Console.ReadLine());
var uchsnik_2 = double.Parse(Console.ReadLine());
var uchsnik_3 = double.Parse(Console.ReadLine());
int res = (int)uchsnik_1 + (int)uchsnik_2 + (int)uchsnik_3;
int res2 = res / 60;
int dop = 60 * res2;
int second = res - dop;
if(second > 10)
{
    Console.WriteLine(res2 + ":" + second);
}
else if(second < 10)
{
    Console.WriteLine(res2 + ":" + "0" + second);
}
else
{
    Console.WriteLine("EROR");
}