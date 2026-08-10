int NumGruz = int.Parse(Console.ReadLine());
List<double> VesGruz = new List<double>(); 

List<double> MicAvto = new List<double>(); 
List<double> Fura = new List<double>(); 
List<double> Train = new List<double>(); 

for (int i = 0; i < NumGruz; i++)
{
    int num = int.Parse(Console.ReadLine());
    VesGruz.Add(num);
}

for (int i = 0; i < NumGruz; i++)
{
    if(VesGruz[i] <= 3)
    {
        MicAvto.Add(VesGruz[i]);
    }
    else if(VesGruz[i] > 3 && VesGruz[i] <= 11)
    {
        Fura.Add(VesGruz[i]);
    }
    else if(VesGruz[i] > 11)
    {
        Train.Add(VesGruz[i]);
    }
}

var oneProc = 100 / VesGruz.Sum();

double SredCena = Math.Round(((MicAvto.Sum()*200) + (Fura.Sum() * 175) + (Train.Sum() * 120)) / VesGruz.Sum(),2);

Console.WriteLine(SredCena);
Console.WriteLine(Math.Round(MicAvto.Sum() * oneProc,2) + " %");
Console.WriteLine(Math.Round(Fura.Sum() * oneProc,2) + " %");
Console.WriteLine(Math.Round(Train.Sum() * oneProc,2) + " %");


