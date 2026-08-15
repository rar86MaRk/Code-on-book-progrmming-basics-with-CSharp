int n = int.Parse(Console.ReadLine());
List<int> numbers = new List<int>();
List<int> p1 = new List<int>();
List<int> p2 = new List<int>();
List<int> p3 = new List<int>();

for(int i = 0;i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    numbers.Add(num);
}

for(int i = 0;i < n; i++)
{
    if(numbers[i] % 2 == 0)
    {
        p1.Add(numbers[i]);
    }
    
    if(numbers[i] % 3 == 0)
    {
        p2.Add(numbers[i]);
    }
    
    if(numbers[i] % 4 == 0)
    {
        p3.Add(numbers[i]);
    }
}

double vsegoAll = numbers.Count();
double p1All = p1.Count();
double p2All = p2.Count();
double p3All = p3.Count();

double oneProc = 100 / vsegoAll;

Console.WriteLine(Math.Round(p1All * oneProc,2));
Console.WriteLine(Math.Round(p2All * oneProc,2));
Console.WriteLine(Math.Round(p3All * oneProc,2));
