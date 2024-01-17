Console.WriteLine("Nece il stajiniz var?");
int staj=Convert.ToInt32(Console.ReadLine());

if( staj>=0 && staj<=2)
{
    Console.WriteLine("Sizin maasiniz 2000");

}
else if( staj>2 && staj<=5)
{
    Console.WriteLine("Sizin maasiniz 5000");
}
else if( staj>5 && staj<=10)
{
    Console.WriteLine("Sizin maasiniz 10000");
}
