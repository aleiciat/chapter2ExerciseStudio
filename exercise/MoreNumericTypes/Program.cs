using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\"MPG Calculator\"\n");
            Console.WriteLine("On your last trip, how many miles did you drive?");
            int miles = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas did you use?");
            int gallons = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your vehicle gets: " + miles/gallons + " mpg"); 
        }
    }
}
