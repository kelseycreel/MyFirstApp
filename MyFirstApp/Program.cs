using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);
            Console.ReadLine();

            //if (userEntry == "Nathan")
            //{
            //    Console.WriteLine("You think so.");
            //}
            //else
            //{
            //    Console.WriteLine("You are the most.");
            //}

            //var i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine($"Current value of i is {i++}");
            //}

            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Current value of i is {i}");
            //}

            foreach (var currentChar in userEntry)
            {
                if (currentChar == 'e')
                {
                    continue;
                }
                Console.WriteLine($"the current character is {currentChar}");
            }

            switch (userEntry)
            {
                case "Kelsey":
                case "Monica":
                case "Jacob":
                    Console.WriteLine("it's a student");
                    break;
                default:
                    Console.WriteLine("it's not a student");
                    break;
            }

            // turnery
            var isNathan = userEntry == "Nathan" ? true : false;

            //example of try catch throw error
            //try
            //{
            //    var y = 0;
            //    var x = 1 / y;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}


        }
    }
}

