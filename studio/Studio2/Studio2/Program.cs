using System;

namespace Studio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.) I can't make classes without ruining my code. 
            // 2.) My mpg calculation is wrong. 
            // 3.) I can't throw errors and exit the code.
            // 4.) I can't compare the radius, a double, to a string.

            double radius;
            do
            {
                Console.WriteLine("Enter a radius: ");
                radius = Double.Parse(Console.ReadLine());
            } while (radius < 0);
          
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);

            Console.WriteLine("It's circumference is: " + circumference + ", and diameter is: " + diameter + ".");

            Console.WriteLine("How many miles per gallon does your vehicle get?");
            double mpg = Double.Parse(Console.ReadLine());
            double gallons = mpg / circumference;

            Console.WriteLine("This is how many gallons of gas it will take to go around a circle of your radius in miles: " + gallons);
        }
    }
}
