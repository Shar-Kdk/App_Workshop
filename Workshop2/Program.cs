namespace Workshop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Desc();
        }

        public static void Desc()
        {
            Console.WriteLine("=== Task 1: Variables and String Interpolation ===");
            Console.WriteLine();
            String userName = "Shar";
            int luckyNumber = 2;
            Console.WriteLine($"Hello {userName}!, Your lucky number is {luckyNumber}.");
            Console.WriteLine();

            Console.WriteLine("=== Task 2: Constants and Circle Class ===");
            Circle circle = new Circle(6);
            System.Console.WriteLine("Area: " + circle.CalculateArea());
            System.Console.WriteLine("Perimeter: " + circle.CalculatePerimater());
            Console.WriteLine();






        }


        public class Circle
        {
            // Pi constant
            public const float pi = 3.14F;
            public int radius;

            public Circle(int radius)
            {
                this.radius = radius;
            }
            public float CalculateArea()
            {
                return pi * radius * radius;
            }
            public float CalculatePerimater()
            {
                return 2 * pi * radius;
            }
        }


    }    
}
