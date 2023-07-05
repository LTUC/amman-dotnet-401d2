namespace Enums
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Product prod = Product.Milk;
            //Console.WriteLine((int)prod);

            int val = 5;
            Console.WriteLine((Product)val);
        }

        public void ProcessTheProduct(int productId)
        {


            if (productId == (int)Product.Milk)
            {
                
                //// Implementation of procissing the milk
                Console.WriteLine("Procees the milk");

            }
            else if (productId == (int)Product.Juice)
            {
                Console.WriteLine("Procees the Juice");
            }
            else if (productId == (int)Product.Tea)
            {
                Console.WriteLine("Procees the Tea");
            }
        }


    }

    public enum Product
    { 
        Milk = 3,
        Juice = 5,
        Tea = 5
    }

    

}