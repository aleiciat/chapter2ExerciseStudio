using System;

namespace Hello__World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + "!");
        }
    }
}
