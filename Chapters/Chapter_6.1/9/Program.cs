int n = int.Parse(Console.ReadLine()!);

int pust_central = 0;
int pust_left = 0;
int pust_right = 0;

int contur = 1;
int contur2 = 1;

if(n % 2 == 0)
{
    pust_central = 0; //Настройка
    pust_left = (n/2)-1;
    pust_right = (n/2)-1;

    for (int i = 0; i < (n/2);i++)
    {
        Console.WriteLine(new string('-', pust_left) + new string('*', contur) + new string ('-', pust_central) + new string('*', contur2) + new string('-', pust_right));
        
        pust_central = pust_central + 2;
        pust_left = pust_left - 1;
        pust_right = pust_right - 1;
    }

    pust_central = pust_central - 4;
    pust_left = pust_left + 2;
    pust_right = pust_right + 2;

    for (int i = 0; i < (n/2)-1; i++)
    {
        Console.WriteLine(new string('-', pust_left) + new string('*', contur) + new string ('-', pust_central) + new string('*', contur2) + new string('-', pust_right));
        
        pust_central = pust_central - 2;
        pust_left = pust_left + 1;
        pust_right = pust_right + 1;
    }
}
else
{
    contur2 = 0;

    pust_central = 0; //Настройка
    pust_left = n/2;
    pust_right = n/2;

    for (int i = 0; i < (n/2)+1;i++)
    {
        Console.WriteLine(new string('-', pust_left) + new string('*', contur) + new string ('-', pust_central) + new string('*', contur2) + new string('-', pust_right));
        
        contur2 = 1;

        if(i == 1){pust_central = pust_central + 2;}else{pust_central = pust_central + 1;}
        pust_left = pust_left - 1;
        pust_right = pust_right - 1;
    }

    pust_central = pust_central - 3;
    pust_left = pust_left + 2;
    pust_right = pust_right + 2;

    for (int i = 0; i < (n/2);i++)
    {
        if(i == (n/2)-1){contur2 = 0;}

        Console.WriteLine(new string('-', pust_left) + new string('*', contur) + new string ('-', pust_central) + new string('*', contur2) + new string('-', pust_right));

        pust_central = pust_central - 1;
        pust_left = pust_left + 1;
        pust_right = pust_right + 1;
    }
}