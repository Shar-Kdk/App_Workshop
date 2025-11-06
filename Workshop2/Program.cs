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


            Console.WriteLine("=== Task 4: Arrays and Array Methods ===");
            int[] numbers = { 9, 2, 7, 4, 1 };

            Array.Sort(numbers);
            Console.WriteLine("Sorted array:");
            foreach (int n in numbers)
                Console.Write(n + " ");

            Array.Reverse(numbers);
            Console.WriteLine("\n Reversed array:");
            foreach (int n in numbers)
                Console.Write(n + " ");

            int position = Array.IndexOf(numbers, 7);
            Console.WriteLine($"\n Position of 7: {position}");
            Console.WriteLine();

            Console.WriteLine("=== Task 5: DateTime and TimeSpan ===");
            DateTime birthDate = new DateTime(2004, 5, 24);
            DateTime currentDate = DateTime.Now;

            TimeSpan ageSpan = currentDate - birthDate;
            int ageYears = (int)(ageSpan.TotalDays / 365.25);

            Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Age: {ageYears} years");

            DateTime newDate = birthDate.AddDays(10);
            Console.WriteLine($"Birthdate + 10 days: {newDate.ToShortDateString()}");
            Console.WriteLine();


            Console.WriteLine("=== Task 6: Generic Collections (List and Dictionary) ===");
            List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };
            fruits.Add("Orange");
            fruits.Remove("Mango");

            Console.WriteLine("Fruits List:");
            foreach (string fruit in fruits)
                Console.WriteLine(fruit);

            Dictionary<int, string> fruitDict = new Dictionary<int, string>
            {
                {1, "Apple"},
                {2, "Banana"},
                {3, "Orange"}
            };
            fruitDict.Add(4, "Grapes");

            Console.WriteLine("\nFruit Dictionary:");
            foreach (var pair in fruitDict)
                Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");

        }


        public class Circle
        {
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
