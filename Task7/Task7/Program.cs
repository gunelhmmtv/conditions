Console.WriteLine("Types of weather");
string weather=Console.ReadLine();

switch (weather)
{
    case "cloudy":
        Console.WriteLine("It might be cold, you need a jacket.");
            break;
    case "sunny":
        Console.WriteLine("Have a nice day!");
        break;
    case "snowy":
        Console.WriteLine("the weather is cold, don't forget your hat and gloves.");
        break;
}
