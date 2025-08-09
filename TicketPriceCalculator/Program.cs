using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ticket Price Calculator");
            int age;
            while (true)
            {
                Console.Write("Enter age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age >= 0)
                    break;
                Console.WriteLine("Invalid input. Please enter a non-negative integer for age.");
            }

            int price = (age >= 65 || age <= 12) ? 7 : 10;
            Console.WriteLine($"Age: {age} => Ticket price: GHC{price}");
        }
    }
}
