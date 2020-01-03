using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Great Giveaway\n");
            Console.Write("Enter door 1, 2 or 3 : ");
            string userValue = Console.ReadLine();
            string message = "";
            if (userValue == "1")
            {
                message = "You won a new car!";
            }
            else if(userValue == "2")
            {
                message = "You won a new boat!";
            }
            else if(userValue == "3")
            {
                message = "You won a new cat!";
            }
            else
            {
                message = "Enter a valid input";
            }

            Console.WriteLine(message);


            int x = 7;
            string result = (x % 2 == 0) ? "even" : "odd";
            Console.Write("The number " + x + " is ");
            Console.Write(result);
            Console.Write(".");
        }
    }
}
