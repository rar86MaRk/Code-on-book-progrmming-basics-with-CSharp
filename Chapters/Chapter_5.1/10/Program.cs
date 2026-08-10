using System.Linq;

var n = int.Parse(Console.ReadLine());
int sum = 0;
List<int> numbers = new List<int>();
int next = 0;
int final = 0;
int lost_final = 0;
bool found = false;

for (int i = 0;i < n; i++)
{
    int H = int.Parse(Console.ReadLine());
    numbers.Add(H);
}

for (int i = 0;i < n; i++)
{
    int pass = numbers[i];
    List<int> test = numbers.Where((item, index) => index != i).ToList();
    int su = test.Sum();
    if(su == pass)
    {
       final =  pass;
       found = true;
       break; 
    }
}

if (found)
{
    Console.WriteLine("Да, сумма = " + final);
}
else
{
    int maxElement = numbers.Max();
    int sumOfOthers = numbers.Sum() - maxElement;               
    int difference = Math.Abs(maxElement - sumOfOthers);    
    Console.WriteLine("Нет, разность = " + difference);
}
