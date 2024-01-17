Console.WriteLine("Terefleri daxil edin");
double side1=Convert.ToDouble(Console.ReadLine());
double side2 = Convert.ToDouble(Console.ReadLine());
double side3 = Convert.ToDouble(Console.ReadLine());

if ((side1+side2)>side3 && (side1+side3)>side2 && (side2+side3)>side1)
{
    Console.WriteLine("Movcuddur");
}
else
{
    Console.WriteLine("Movcud deyil");
}