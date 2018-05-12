using System;

namespace Lab01_AboutMe
{
    class Program
    {
        public static short correct = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Question 1
            if (AskColor()) correct++;

            //Question 2
            if(AskCats()) correct++;

            //Question 3
            try
            {
                if (FavoriteBeverage() != 1)
                {
                    Console.WriteLine("Nope, I love coffee!");
                }
                else
                {
                    Console.WriteLine("Congrats! You are correct!");
                    correct++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        

            //Question 4:
            AskQuestion("Am I an only child?", "no");

            //Question 5
            AskQuestion("What is my programming language of choice?", "c#");


            Console.WriteLine($"You answered {correct} questions correctly");

        }

        public static bool AskColor()
        {
            Console.WriteLine("What is Amanda's Favorite color");
            string color = Console.ReadLine();
            if (color != null && color.ToLower() != "red")
            {
                Console.WriteLine("You are incorrect");
                return false;
            }
            else
            {
                Console.WriteLine("Congratulation, You are correct");
                return true;
            }
        }

        public static bool ProgrammingLanguage()
        {
            Console.WriteLine("What is my favorite programming language");
            string answer = Console.ReadLine();
            if (answer != null && answer.ToLower() != "c#")
            {
              
                Console.WriteLine("You are incorrect");
                return false;
            }
            else
            {
                Console.WriteLine("Congratulation, You are correct");
                return true;
            }
        }

        public static bool AskCats()
        {
            Console.WriteLine("How many cats does Amanda own?");
            string number = Console.ReadLine();
            try
            {
                if (Int32.Parse(number) == 2) // TryParse returns T/F, Parse returns an exception
                {

                    Console.WriteLine("Yes! 2 Cats!");
                    return true;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public static int FavoriteBeverage()
        {
            Console.WriteLine("What is my favorite morning beverage");
            Console.WriteLine("1. Coffee");
            Console.WriteLine("2. Orange Juice");
            Console.WriteLine("3. Tea");
            Console.WriteLine("4. Smoothie");

            int drink = Int32.Parse(Console.ReadLine());
            if (drink > 0 && drink < 5)
            {
                return drink;
            }
            throw new Exception("Incorrect value entered");
        }

        public static void AskQuestion(string question, string answer)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();

            if (string.Equals(response, answer, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("You are correct!");
                correct++;
            }
            else
            {
                Console.WriteLine($"Nope, the correct answer is {answer}");
            }

        }

    }
}
