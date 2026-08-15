int s_pool = int.Parse(Console.ReadLine());
int p_one = int.Parse(Console.ReadLine());
int p_two = int.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
double p_one_to_h = p_one * h;
double p_two_to_h = p_two * h;
if (p_one_to_h + p_two_to_h > s_pool)
{
    Console.WriteLine("За " + h + " часа басейн переполнится на " + (p_one_to_h + p_two_to_h - s_pool) + " литров.");
}
else if (p_one_to_h + p_two_to_h < s_pool)
{
    double one_procent = s_pool / 100;
    double prc_p_one = p_one_to_h / one_procent;
    double prc_p_two = p_two_to_h / one_procent;
    double prc_res = prc_p_one + prc_p_two;
    Console.WriteLine("Басейн заполнен на " + prc_res + "%. Труба 1: " + prc_p_one + "%.Труба 2: " + prc_p_two + "%.");
}
else
{
    Console.WriteLine("Eror");
}