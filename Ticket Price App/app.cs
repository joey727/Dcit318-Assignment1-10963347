using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            decimal ticketPrice;
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7.00m;
                Console.WriteLine("You are eligible for a discounted ticket price!");
            }
            else
            {
                ticketPrice = 10.00m;
            }

            Console.WriteLine($"Your ticket price is: ghc{ticketPrice:F2}");
            Console.ReadLine();
        }
    }
}

