using System.Linq;

int n = int.Parse(Console.ReadLine());
List<double> numbers = new List<double>();



for (int i = 0;i < n;i++)
{
    var timeVal = double.Parse(Console.ReadLine());
    numbers.Add(timeVal);
}

var EvenNumbers = numbers.Where((item, index) => index % 2 == 0).ToList(); //Чётные
var OddNumbers = numbers.Where((item, index) => index % 2 != 0).ToList();  //Нечётные

Console.WriteLine("Even Sum = "+EvenNumbers.Sum());
try{Console.WriteLine("Even Min = "+EvenNumbers.Min());}catch{Console.WriteLine("Even Min = No");}
try{Console.WriteLine("Even Max = "+EvenNumbers.Max());}catch{Console.WriteLine("Even Max = No");}
Console.WriteLine("Odd Sum = "+OddNumbers.Sum());
try{Console.WriteLine("Odd Min = "+OddNumbers.Min());}catch{Console.WriteLine("Odd Min = No");}
try{Console.WriteLine("Odd Max = "+OddNumbers.Max());}catch{Console.WriteLine("Odd Max = No");}

