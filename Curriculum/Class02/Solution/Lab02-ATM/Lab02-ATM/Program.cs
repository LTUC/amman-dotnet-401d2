using System;

namespace Lab02_ATM
{
    public class Program
    {
        //The ATM should have the following functionality:
        // 1. View Balance (start out at $5000)
        // 2. Withdraw money
        // 3. Add Money
        // The ATM should be continuous until the user decides to exit. 
        // The ATM should have tests that cover all of the external, non-void methods. 
        //REMEMBER: you cannot test console.writelines..so plan accordingly. 

       public static double Balance = 5000;

        static void Main()
        {
            Console.WriteLine("Welcome to my Bank!");

            Console.WriteLine(@"
                       __-----__
                  ..;;;--'~~~`--;;;..
                /;-~IN GOD WE TRUST~-.\
               //      ,;;;;;;;;      \\
             .//      ;;;;;    \       \\
             ||       ;;;;(   /.|       ||
             ||       ;;;;;;;   _\      ||
             ||       ';;  ;;;;=        ||
             ||LIBERTY | ''\;;;;;;      ||
              \\     ,| '\  '|><| 1995 //
               \\   |     |      \  A //
                `;.,|.    |      '\.-'/
                  ~~;;;,._|___.,-;;;~'
                      ''=--'");

            bool action = true;
            while (action)
            {
                Console.WriteLine("Please select your action (1/2/3/4)?");
                Console.WriteLine("1.Deposit");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.View Balance");
                Console.WriteLine("4.Exit");

                Int32.TryParse(Console.ReadLine(), out int number);

                double value;
                switch (number)
                {

                    case 1:
                        Console.WriteLine("How much would you like to deposit?");
                        Double.TryParse(Console.ReadLine(), out value);
                        Console.WriteLine(Deposit(value) ? "Deposit Successful" : "Invalid Depost");

                        break;
                    case 2:
                        Console.WriteLine($"How much would you like to withdraw?");
                        Double.TryParse(Console.ReadLine(), out value);
                        Withdraw(value);
                        break;
                    case 3:
                        Console.WriteLine($"Your current balance is {Balance}");
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("Would you like to conduct another transaction");
                Console.WriteLine("y/n");
                string answer = Console.ReadLine();
                if (answer != null && answer.ToLower() == "n")
                {
                    action = false;
                }
            }

        }

        public static string Withdraw(double amount)
        {
            if (amount > Balance)
            {
                return $"{amount} is greater than your balance of {Balance}";
            }
            if (amount <= 0)
            {
                return "Your are trying to withdraw an invalid amount";
            }

            Balance -= amount;


            return "Withdraw Successful";
        }

        public static bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }

            return false;
        }


    }
}
