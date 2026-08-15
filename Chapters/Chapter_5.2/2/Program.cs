int old = int.Parse(Console.ReadLine());
double pirceMachine = double.Parse(Console.ReadLine());
int pirceToys = int.Parse(Console.ReadLine());

int Toys = 0;
int MoneyPrice = 0;
int ToysMoney = 0;
int oneyForBtM = 10;

for (int i = 1; i <= old; i++)
{
    if (i % 2 == 0)
    {
        MoneyPrice = MoneyPrice + (oneyForBtM - 1);
        oneyForBtM += 10;
    }
    else
    {
        Toys = Toys + 1;
    }
}


ToysMoney = Toys * pirceToys;
MoneyPrice = MoneyPrice + ToysMoney;


if(MoneyPrice >= pirceMachine)
{
    Console.WriteLine("Да! "+(MoneyPrice - pirceMachine));
}
else if(MoneyPrice < pirceMachine)
{
    Console.WriteLine("Нет! "+(pirceMachine - MoneyPrice));
}