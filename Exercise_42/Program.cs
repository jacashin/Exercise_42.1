using System;

namespace Exercise_42
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a 'x' coordinate");

            var userInput1 = Console.ReadLine();

            Point point = new Point();

            int.TryParse(userInput1, out int x);

           point.X = x;

            Console.WriteLine("Please enter a 'y' coordinate");

            var userInput2 = Console.ReadLine();

            int.TryParse(userInput2, out int y);

            point.Y = y;

            Console.WriteLine($"{point.X}, {point.Y} ");

            Console.ReadLine();

        }
    }
}
