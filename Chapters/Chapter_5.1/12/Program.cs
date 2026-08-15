int n = int.Parse(Console.ReadLine());
List<int> numbers = new List<int>();
int maxDifference = 0;

for(int i = 0; i < n; i++)
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int finalNum = num1 + num2;
    numbers.Add(finalNum);
}

if(!numbers.Any() || numbers.All(x => x == numbers[0]))
{
    Console.WriteLine("Да, значение = "+numbers[0]);
}

else
{
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        int difference = Math.Abs(numbers[i + 1] - numbers[i]);
        if (difference > maxDifference)
        {
            maxDifference = difference;
        }
    }
    Console.WriteLine("Нет, maxdiff = "+maxDifference);
}