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

        // prompting user to get input for totalMilesPerDay
        Console.WriteLine("Input Total Miles Driven Per Day:  ");
        totalMilesPerDay = Convert.ToInt32(Console.ReadLine());

        // prompting user to get input for costPerGallon
        Console.WriteLine("Input Cost Per Gallon Of Gasoline (in cents):  ");
        costPerGallon = Convert.ToInt32(Console.ReadLine());

        // prompting user to get input for milesPerGallon
        Console.WriteLine("Input Average Mile Per Gallon:  ");
        milesPerGallon = Convert.ToInt32(Console.ReadLine());

        // prompting user to get input for parkingFeePerDay
        Console.WriteLine("Input Parking Fee Per Day (in cents):  ");
        parkingFeePerDay = Convert.ToInt32(Console.ReadLine());

        // prompting user to get input for tollsPerDay
        Console.WriteLine("Input Tolls Per Day (in cents):  ");
        tollsPerDay = Convert.ToInt32(Console.ReadLine());
    }
}
