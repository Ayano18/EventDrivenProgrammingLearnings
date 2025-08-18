// See https://aka.ms/new-console-template for more information
using System;
namespace Main
{
    public class Laboratoryone
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the total number of your enrolled courses: ");
            int courses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of your favorite book: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total enrolled courses: " + courses);
            Console.WriteLine("Price of my favorite book " + price);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
