int input_value = int.Parse(Console.ReadLine());

if (input_value <= 9)
{
    if (input_value == 0)
    {
        Console.WriteLine("zero");
    }
    else if (input_value == 1)
    {
        Console.WriteLine("one");
    }
    else if (input_value == 2)
    {
        Console.WriteLine("two");
    }
    else if (input_value == 3)
    {
        Console.WriteLine("tree");
    }
    else if (input_value == 4)
    {
        Console.WriteLine("four");
    }
    else if (input_value == 5)
    {
        Console.WriteLine("five");
    }
    else if (input_value == 6)
    {
        Console.WriteLine("six");
    }
    else if (input_value == 7)
    {
        Console.WriteLine("seven");
    }
    else if (input_value == 8)
    {
        Console.WriteLine("eight");
    }
    else if (input_value == 9)
    {
        Console.WriteLine("nine");
    }
    else
    {

    }
}
else
{
    int desoatki = input_value / 10;
    int edenici = input_value % 10;

    string des = "";
    string ed = "";

    if (desoatki == 0)
    {
        des = "zeroty";
    }
    else if (desoatki == 1)
    {
        des = "ten";
    }
    else if (desoatki == 2)
    {
        des = "twenty";
    }
    else if (desoatki == 3)
    {
        des = "thirty";
    }
    else if (desoatki == 4)
    {
        des = "forty";
    }
    else if (desoatki == 5)
    {
        des = "fifty";
    }
    else if (desoatki == 6)
    {
        des = "sixty";
    }
    else if (desoatki == 7)
    {
        des = "seventy";
    }
    else if (desoatki == 8)
    {
        des = "eighty";
    }
    else if (desoatki == 9)
    {
        des = "ninety";
    }
    else
    {

    }


    if (edenici == 0)
    {
        ed = "zero";
    }
    else if (edenici == 1)
    {
        ed = "one";
    }
    else if (edenici == 2)
    {
        ed = "two";
    }
    else if (edenici == 3)
    {
        ed = "tree";
    }
    else if (edenici == 4)
    {
        ed = "four";
    }
    else if (edenici == 5)
    {
        ed = "five";
    }
    else if (edenici == 6)
    {
        ed = "six";
    }
    else if (edenici == 7)
    {
        ed = "seven";
    }
    else if (edenici == 8)
    {
        ed = "eight";
    }
    else if (edenici == 9)
    {
        ed = "nine";
    }
    else
    {

    }
    Console.WriteLine(des+" "+ed);
}
