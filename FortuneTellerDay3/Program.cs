using System;

namespace FortuneTellerDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            //Console.Clear();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's the number of your birth month?");
            int birthMonth;
            birthMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's your favorite ROYGBIV color?");
            string color = Console.ReadLine();


            if (color.ToLower().Equals("red") || color.ToLower().Equals("orange") || color.ToLower().Equals("yellow") || color.ToLower().Equals("green") || color.ToLower().Equals("blue") || color.ToLower().Equals("indigo") || color.ToLower().Equals("violet"))
            {
                Console.WriteLine("That's Awesome!");
            }

            else 
            {
                Console.WriteLine("Type HELP to get a list of ROYGBIV colors");
                string helpLine = Console.ReadLine();

                if (helpLine.Equals("HELP"))
                {

                    Console.WriteLine("The ROYGBIV colors are red, orange, yellow, green, blue, indigo, violet");
                }


                else
                {
                    Console.WriteLine("You must type HELP");
                    string helpLine2 = Console.ReadLine();

                    if (helpLine2.Equals("HELP"))
                    {

                        Console.WriteLine("The ROYGBIV colors are red, orange, yellow, green, blue, indigo, violet");
                    }


                    Console.WriteLine("How many siblings do you have?");
                    int siblingCount;
                    siblingCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("That's Awesome!");



                }


            }
        }
    }
}
