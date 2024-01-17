Console.WriteLine("Saati daxil edin");
int saat=Convert.ToInt32(Console.ReadLine());

if (saat<=12)
{
    Console.WriteLine("Sabahiniz xeyir!");
}
else if (saat>12 && saat<=17)
{
    Console.WriteLine("Gunortaniz xeyir!");
}
else if (saat>17 && saat<24)
{
    Console.WriteLine("Axsaminiz xeyir");
}
