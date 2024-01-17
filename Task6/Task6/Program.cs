Console.WriteLine("Terefleri daxil edin");
double side1 = Convert.ToDouble(Console.ReadLine());
double side2 = Convert.ToDouble(Console.ReadLine());
double side3 = Convert.ToDouble(Console.ReadLine());

if(side1==side2 && side2==side3 && side1==side3)
{
    Console.WriteLine("Beraberterefli");
}
else if(side1==side2 ||  side2==side3 || side1==side3)
{
    Console.WriteLine("Beraberyanli");
}
else
{
    Console.WriteLine("Muxtelif terefli");
}