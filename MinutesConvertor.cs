using System;

public class MinutesConvertor
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Please enter how minutes have you worked.");
        int minutes = int.Parse(Console.ReadLine());

        //Conversion to hours and minutes

        int hours = minutes / 60;

        int newMinutes = minutes % 60;

        Console.WriteLine("You worked {0} hours and {1} minutes.", hours, newMinutes);
    }
}
