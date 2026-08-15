int n = int.Parse(Console.ReadLine());
int zvezd_cond = 0;
int chert_cond = 0;
int resh = 0;

if(n % 2 == 0)
{
    zvezd_cond = 2;
    chert_cond = n - 2;
    for (int i = 0; zvezd_cond <= n; i++)
    {
        Console.WriteLine(new string('-',(chert_cond / 2))+new string('*',zvezd_cond)+new string('-',(chert_cond / 2)));
        zvezd_cond = zvezd_cond + 2;
        chert_cond = chert_cond - 2;
        resh = resh + 1;
    }
    for (int i = 0; i < (n - resh); i++)
    {
        Console.WriteLine(new string('|',1)+new string('*',n-2)+new string('|',1));
    }
}
else
{
    zvezd_cond = 1;
    chert_cond = n - 1;
    for (int i = 0; zvezd_cond <= n; i++)
    {
        Console.WriteLine(new string('-',(chert_cond / 2))+new string('*',zvezd_cond)+new string('-',(chert_cond / 2)));
        zvezd_cond = zvezd_cond + 2;
        chert_cond = chert_cond - 2;
        resh = resh + 1;
    }
    for (int i = 0; i < (n - resh); i++)
    {
        Console.WriteLine(new string('|',1)+new string('*',n-2)+new string('|',1));
    }     
}