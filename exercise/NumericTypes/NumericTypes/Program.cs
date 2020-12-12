using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to our 'Area Calculator'! You can calculate the area of a rectangle or square here. \n");
            Console.WriteLine("Okay, let's get started. What units are we using? Inches or feet? \n");
                string unit = Console.ReadLine();
            Console.WriteLine("\nWhat is the length of our rectangle? (Do not include units.)  \n");
                double length = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nWhat is the width of our rectangle? (Do not include units.) \n");
                double width = Double.Parse(Console.ReadLine());
                double area = length * width;
                unit = unit.ToLower();

                if (unit == "inches" && area == 1)
                {
                    unit = "inch";
                }

                if (unit == "feet" && area == 1)
                {
                    unit = "foot";
                }

            Console.WriteLine("\nOur rectangle is: " + area + " " + unit);
        }
    }
}
