int temp;

do
{
    Console.Write("temperature in celsius (must be between -50 and 150): ");
    temp = int.Parse(Console.ReadLine());

    if (temp < 0 )
    {
        Console.WriteLine("freezing.");
    }
    if (temp >= 0 && temp < 30 )
    {
        Console.WriteLine("normal.");
    }
    if (temp >= 30 && temp <= 100)
    {
        Console.WriteLine("hot.");
    }
    else if (temp >100 && temp <= 150)
    {
        Console.WriteLine("very hot.");
    }
   
} while (temp > 150 || temp < -50);