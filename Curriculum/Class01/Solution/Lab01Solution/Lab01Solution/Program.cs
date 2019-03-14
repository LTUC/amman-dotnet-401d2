using System;

namespace Lab01Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!");
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception in Main has been caught");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program is complete.");
            }

            Console.Read();
        }

        public static void StartSequence()
        {
            try
            {
                Console.WriteLine("Please enter a number greater than zero");
                string answer = Console.ReadLine();
                int number = Convert.ToInt32(answer);
                int[] numbers = new int[number];
                numbers = Populate(numbers);
                int sum = GetSum(numbers);
                int product = GetProduct(numbers, sum);
                decimal quotient = GetQuotient(product);

                Console.WriteLine($"Your array is size: {numbers.Length}");
                Console.WriteLine($"The numbers in the array are {string.Join(',', numbers)}");
                Console.WriteLine($"The sum of the array is {sum}");
                int chosenNumber = product / sum;
                Console.WriteLine($"{sum} * {chosenNumber} = {product}");
                decimal mystery = product / quotient;
                Console.WriteLine($"{product} / {mystery} =  {quotient}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static int[] Populate(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Please enter number: {i + 1} of {numbers.Length}");
                string answer = Console.ReadLine();
                int num = Convert.ToInt32(answer);
                numbers[i] = num;
            }
            return numbers;

        }

        static int GetSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low");
            }

            return sum;
        }

        public static int GetProduct(int[] numbers, int sum)
        {
            try
            {
                Console.WriteLine($"Please select a random number between 1 and {numbers.Length}");
                string answer = Console.ReadLine();
                int random = Convert.ToInt32(answer);
                int product = numbers[random - 1] * sum;
                return product;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        public static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine($"Please enter a number to divide your product {product} by");
                string answer = Console.ReadLine();
                int number = Convert.ToInt32(answer);

                decimal temp = decimal.Divide(product, number);

                return temp;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }
    }
}
