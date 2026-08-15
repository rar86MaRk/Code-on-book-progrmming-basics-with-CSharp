var n = int.Parse(Console.ReadLine());
List<double> numbers = new List<double>();

int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;

for(int i = 0; i < n; i++)
{
    int numRes = int.Parse(Console.ReadLine());
    numbers.Add(numRes);
}

double numCount = numbers.Count();
double oneProc = numCount / 100;//3:100=0.03


for(int i = 0; i < numbers.Count(); i++)
{
    double num = numbers[i];
    if(num < 200)
    {
        p1 = p1 + 1;//2
    }
    else if(num >= 200 && num <= 399)
    {
        p2 = p2 + 1;
    }
    else if(num >= 400 && num <= 599)
    {
        p3 = p3 + 1;
    }
    else if(num >= 600 && num <= 799)
    {
        p4 = p4 + 1;
    }
    else if(num >= 800)
    {
        p5 = p5 + 1;//1
    }
}

Console.WriteLine(Math.Round(p1/oneProc, 2)+"%");
Console.WriteLine(Math.Round(p2/oneProc, 2)+"%");
Console.WriteLine(Math.Round(p3/oneProc, 2)+"%");
Console.WriteLine(Math.Round(p4/oneProc, 2)+"%");
Console.WriteLine(Math.Round(p5/oneProc, 2)+"%");


//3=100% 3/100=0,03       2/0.03=66.67     1/0.03=33.33