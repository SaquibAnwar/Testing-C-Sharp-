using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            int x, y;
            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            _ = Console.ReadLine();
            */

            Console.WriteLine("What is your name ? ");
            string firstName;
            Console.Write("Enter your first name : ");
            firstName = Console.ReadLine();
            string lastName;
            Console.Write("Enter your last Name : ");
            lastName = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + " " + lastName);
        }
    }
}
