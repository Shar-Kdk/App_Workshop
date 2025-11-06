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

            Console.WriteLine("=== Task 3: Data Types and Type Conversion ===");
            byte b = 10;
            short s = 200;
            int i = 1000;
            long l = 100000L;
            float f = 10.5F;
            double d = 99.99;
            decimal dec = 123.456M;
            char c = 'A';
            bool flag = true;

            string intToString = i.ToString();
            double stringToDouble = Convert.ToDouble("3.14");

            Console.WriteLine($"byte: {b}");
            Console.WriteLine($"short: {s}");
            Console.WriteLine($"int: {i}");
            Console.WriteLine($"long: {l}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"double: {d}");
            Console.WriteLine($"decimal: {dec}");
            Console.WriteLine($"char: {c}");
            Console.WriteLine($"bool: {flag}");
            Console.WriteLine($"Integer to String: {intToString}");
            Console.WriteLine($"String to Double: {stringToDouble}");
            Console.WriteLine();





            Console.ReadLine();
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
