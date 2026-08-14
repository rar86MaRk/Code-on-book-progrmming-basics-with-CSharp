int n = int.Parse(Console.ReadLine()!);

int fortSize = n / 2;
int midSize = 2 * n - 2 * fortSize - 4;

for (int i = 0; i < n - 2; i++)
{
    Console.WriteLine(('/' + new string('^', fortSize) + '\\') + new string(' ',midSize) + ('/' + new string('^', fortSize) + '\\'));
    for (int s = 0; i < (n - 2); i++)
    {
        if(i == (n - 3) && midSize != 0)
        {
            Console.WriteLine('|' + new string(' ', (n - 2)) + new string('_',midSize) + new string(' ', (n - 2)) + '|');
        }
        else
        {
            Console.WriteLine('|' + new string(' ', (n * 2) - 2) + '|');
        }
    }
    Console.WriteLine(('\\' + new string('_', fortSize) + '/') + new string(' ',midSize) + ('\\' + new string('_', fortSize) + '/'));
}
