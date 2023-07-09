namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
           //var processor = new PhotoProcessor();

           // PhotoFilters photoFilters = new PhotoFilters();
           // System.Action<Photo> filterHandler = photoFilters.ApplyBrightness;

           // filterHandler += photoFilters.ApplyContrast;

           // processor.Process("photo.jbg", filterHandler);

           // //
           // Console.WriteLine("Filters on car image");
           // processor.Process("car.jpg", AddRedFilter);



            //////
            ///Lambda Ex

            //Console.WriteLine(Square(5));

            /// args => expression
            /// number => number * number
            /// 

            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));



        }

        static int Square(int number)
        {
            return number * number;
        }



        public static void AddRedFilter(Photo photo)
        {
            Console.WriteLine("Add red filter");
        }
    }
}