Console.WriteLine("Ededleri daxil edin:");
double eded1 =Convert.ToDouble(Console.ReadLine());
double eded2 = Convert.ToDouble(Console.ReadLine());
double eded3 = Convert.ToDouble(Console.ReadLine());

double ortalama = (eded1 + eded2 + eded3) / 3;

if (ortalama < 20)
{
    Console.WriteLine("Aktiv");
}
else if (ortalama > 20)
{
    Console.WriteLine("Deaktiv");
}



