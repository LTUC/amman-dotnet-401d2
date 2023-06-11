namespace BugTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //GetAge();

            Squares();
        }

        private static void Squares()
        {
            // 300 Lines of code 
            int[] events = new int[3] { 2, 4, 8 };

            foreach (int number in events)
            {
                Console.WriteLine(number * number);
            }
        }

        private static void GetAge()
        {
            try
            {
                Console.WriteLine("Please Enter You age");

                int age = Convert.ToInt32(Console.ReadLine());

                int nextAge = age + 1;


                Console.WriteLine($"Ahmad age is {age}");
            }
            catch (OverflowException overflowEx)
            {
                Console.WriteLine($"That is a hige number {overflowEx.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"You have not enter a number {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Yoh have Some thing wrong {ex.Message}");
            }
            finally
            {
                Console.Clear();

            }
        }
    }
}