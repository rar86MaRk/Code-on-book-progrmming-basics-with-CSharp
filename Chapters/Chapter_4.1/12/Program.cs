int h = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

bool inPram1 = (x < (h * 3) && y < h);
bool inPram2 = (x > h && x < (h * 2) && y < (4 * h) && y > h);

bool out1 = (x > (3 * h) && y > h||y > (4 * h));
bool out2 = ((y > h && y < (4 * h) && x < h) || (y > h && y < (4 * h) && x > (2 * h) && x < (3 * h)));

if (inPram1||inPram2)
{
    Console.WriteLine("inside");
}
else if (out1||out2)
{
    Console.WriteLine("outside");
}
else
{
    Console.WriteLine("border");
}