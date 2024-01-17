Console.WriteLine("Shobenizi daxil edin:");
string shobe = Console.ReadLine();

if (shobe == "HR")
{
    Console.WriteLine("İnsan Resursları şöbəsi"); 
}
else if (shobe == "IT")
{
    Console.WriteLine("İnformasiya texnologiyaları şöbəsi");
}
else if (shobe == "FINANCE")
{
    Console.WriteLine("Finans şöbəsi");
}
else
{
    Console.WriteLine("Belə bir şöbə yoxdur");
}


