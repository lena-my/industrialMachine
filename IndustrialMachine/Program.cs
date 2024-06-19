using IndustrialMachine;

/* Beer */
Console.WriteLine("Enter how many liters of beer you have: ");

string litersBeerString = Console.ReadLine(); // enter liters of beer
float litersBeer;
if (float.TryParse(litersBeerString, out litersBeer)) // try to parse into float. if success, litersBeer, if fails, returns false and litersBeer = 0
{
    if (litersBeer < 0)
    {
        Console.WriteLine("Liters of beer cannit be negative.");
    }
} else {
    Console.WriteLine("Invalid number.");
}



/* Bottles */
Console.WriteLine("Enter how many empty bottles you have :");

try
{
    int bottles = Convert.ToInt32(Console.ReadLine()); // convert the entered number to int

    if (bottles < 0) // if number of bottles in negative, then exception
    {
        throw new FormatException("Number of bottles cannot be negative.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid number.");
}

/* Capsules */
Console.WriteLine("Enter how many capsules you have :");
try
{
    int capsules = Convert.ToInt32(Console.ReadLine()); // convert the entered number to int

    if (capsules < 0) // if number of capsules in negative, then exception
    {
        throw new FormatException("Number of capsules cannot be negative.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid number.");
}


BeerEncapsulator beerEncapsulator = new BeerEncapsulator(litersBeer, bottles, capsules);



