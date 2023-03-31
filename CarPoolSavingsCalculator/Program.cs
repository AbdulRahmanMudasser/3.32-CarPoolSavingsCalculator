class C3Q32
{
    static void Main(string[] args)
    {
        // declaring variables for user to input information
        int totalMilesPerDay;
        int costPerGallon;
        int milesPerGallon;
        int parkingFeePerDay;
        int tollsPerDay;

        // declaring variables for estimating cost
        int gallonsUsed;
        int fuelCost;
        int pricePerDay;

        // prompting user to get input for totalMilesPerDay
        Console.Write("Input Total Miles Driven Per Day:  ");
        totalMilesPerDay = Convert.ToInt32(Console.ReadLine());

        // prompting user to get input for costPerGallon
        Console.Write("Input Cost Per Gallon Of Gasoline (in cents):  ");
        costPerGallon = Convert.ToInt32(Console.ReadLine());

        // prompting user to get input for milesPerGallon
        Console.Write("Input Average Mile Per Gallon:  ");
        milesPerGallon = Convert.ToInt32(Console.ReadLine());

        // prompting user to get input for parkingFeePerDay
        Console.Write("Input Parking Fee Per Day (in cents):  ");
        parkingFeePerDay = Convert.ToInt32(Console.ReadLine());

        // prompting user to get input for tollsPerDay
        Console.Write("Input Tolls Per Day (in cents):  ");
        tollsPerDay = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // calculating how many fuel is used
        gallonsUsed = totalMilesPerDay / milesPerGallon;

        // calculating what is the cost of fuel consumed
        fuelCost = gallonsUsed * costPerGallon;

        // calculating total cost
        pricePerDay = fuelCost + tollsPerDay + parkingFeePerDay;

        // converting total price to dollars
        pricePerDay /= 100;

        // displaying cost
        Console.WriteLine("Total Cost Per Day:  " + pricePerDay + "$");
    }
}
