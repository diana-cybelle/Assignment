using System;
namespace CircleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("[A] Compute Area");
            Console.WriteLine("[P] Compute Perimeter");
            Console.WriteLine("[X] Exit");
            Console.Write("Enter your choice: ");
            
            char choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'A':
                    double area = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"The area of the circle is: {area:F2}");
                    break;

                case 'P':
                    double perimeter = 2 * Math.PI * radius;
                    Console.WriteLine($"The perimeter of the circle is: {perimeter:F2}");
                    break;

                case 'X':
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please restart and enter A, P, or X.");
                    break;
            }
        }
    }
}
