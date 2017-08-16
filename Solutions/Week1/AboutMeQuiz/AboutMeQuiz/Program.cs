using System;

namespace AboutMeQuiz
{
    class Program
    {
        public static int counter = 0;
        static void Main(string[] args)
        {
            
                Console.WriteLine("Welcome to my quiz");

                Console.WriteLine("What is your name?");
                string usrName = Console.ReadLine();

                Console.WriteLine($"Hello, {usrName}!");

                Console.WriteLine("Try and answer these questions");

                Console.WriteLine("What is my name?");
                Name(Console.ReadLine());

                Console.WriteLine("What is my favorite Color?");
                Color(Console.ReadLine());

                Console.WriteLine("How many cats do I have?");
                NumberOfPets(Convert.ToInt32(Console.ReadLine()));
          

        }

        public static void Name(string name)
        {
            string correct = "amanda";

            if (name.ToLower() == correct)
            {
                Console.WriteLine("Correct!");
                counter++;
            }
            else
            {
                Console.WriteLine($"Sorry, that is incorrect, my name is {correct}");
            }

        }

        public static void Color(string color)
        {
            string correct = "red";

            if (color.ToLower() == correct)
            {
                Console.WriteLine("Correct!");
                counter++;

            }
            else
            {
                Console.WriteLine($"Sorry, that is incorrect, my favorite color is {correct}");
            }
        }

        public static void NumberOfPets(int number)
        {
            int correct = 2;

            if (number == correct)
            {
                Console.WriteLine($"Correct! I have {correct} cats");
                counter++;
            }
            else
            {
                Console.WriteLine($"Sorry, that is incorrect, I have {correct} cats");
            }
        }

        public static void Exit()
        {
            Console.WriteLine("Thank you for taking my quiz");
            Console.WriteLine($"You answered {counter} of my questions correctly");
            Console.WriteLine("Have a good day!");
            Console.WriteLine("Press any key to exit");

            Console.Read();

        }








    }
}