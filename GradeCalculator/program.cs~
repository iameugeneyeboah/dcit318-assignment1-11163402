using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Calculator");
            double grade;
            while (true)
            {
                Console.Write("Enter numeric grade (0-100): ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                    break;
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }

            string letter;
            if (grade >= 90) letter = "A";
            else if (grade >= 80) letter = "B";
            else if (grade >= 70) letter = "C";
            else if (grade >= 60) letter = "D";
            else letter = "F";

            Console.WriteLine($"Numeric grade: {grade} => Letter grade: {letter}");
        }
    }
}
