using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Type Identifier");
            double a = ReadSide("first");
            double b = ReadSide("second");
            double c = ReadSide("third");

            if (!IsValidTriangle(a,b,c))
            {
                Console.WriteLine("The entered sides do not form a valid triangle (violate triangle inequality).");
                return;
            }

            if (AreEqual(a,b) && AreEqual(b,c))
                Console.WriteLine("Triangle Type: Equilateral");
            else if (AreEqual(a,b) || AreEqual(a,c) || AreEqual(b,c))
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }

        static double ReadSide(string which)
        {
            double val;
            while (true)
            {
                Console.Write($"Enter {which} side length (positive number): ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out val) && val > 0)
                    return val;
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
        static bool AreEqual(double x, double y) => Math.Abs(x - y) < 1e-6;
        static bool IsValidTriangle(double x, double y, double z) => x + y > z && x + z > y && y + z > x;
    }
}
