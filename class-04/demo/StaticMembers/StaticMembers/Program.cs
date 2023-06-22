namespace StaticMembers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(10);

            Console.WriteLine($"Numbers of circiles = {Circle.Instances}");

            var areateOfTheFirstCircle = Circle.CalculateArea(circle1.Radius);

            Console.WriteLine($"The Area of the first cicle is = {areateOfTheFirstCircle}");
        }
    }

    public class Circle
    {
        public static float Pi = 3.14159f;
        public static int Instances = 0;

        public float Radius { get; set; }


        public Circle(float radius)
        {
            this.Radius = radius;
            Instances++;
        }



        public static float CalculateArea(float radius)
        {
            return Pi * radius * radius;
        }
    }

}