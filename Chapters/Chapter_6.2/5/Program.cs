int n = int.Parse(Console.ReadLine()!);

var width = 5 * n;
var leftDash = 3 * n;
var middleDash = 0;
var rightDash = width - leftDash - middleDash - 2;

for(int i = 0; i < n; i++)
{
    Console.WriteLine(new string('-',leftDash) + '*' + new string('-',middleDash) + '*' + new string('-',rightDash));
    rightDash = rightDash - 1;
    middleDash = middleDash + 1;
}

for(int i = 0; i < (n / 2); i++)
{
    Console.WriteLine(new string('*',leftDash) + '*' + new string('-',middleDash) + '*' + new string('-',rightDash));
}

for(int i = 0; i < (n / 2 - 1); i++)
{
    Console.WriteLine(new string('-',leftDash) + '*' + new string('-',middleDash) + '*' + new string('-',rightDash));
    leftDash = leftDash - 1;
    rightDash = rightDash - 1;
    middleDash = middleDash + 2;
}

Console.WriteLine(new string('-',leftDash) + new string('*',middleDash + 2) + new string('-',rightDash));

