namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write subroutines to calculate the areas of 
            // Circle
            // Triangle
            // Rectangle
            // Pentagon
            // Octagon

            Console.WriteLine("enter shape");
            Console.WriteLine("1. circle");
            Console.WriteLine("2. triangle");
            Console.WriteLine("3. rectangle");
            Console.WriteLine("4. pentagon");
            Console.WriteLine("5. octagon");
            Console.Write("enter choice (1-5) ");
            int choice = Convert.ToInt32(Console.ReadLine());
            double area = 0;

            if (choice == 1)
            {
                Console.WriteLine("enter radius");
                double radius = Convert.ToDouble(Console.ReadLine());
                area = areaOfCircle(radius);
            }
            if (choice == 2)
            {
                Console.WriteLine("enter base");
                double Base = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter height");
                double height = Convert.ToDouble(Console.ReadLine());
                area = areaOfTriangle(Base, height);
            }
            if (choice == 3)
            {
                Console.WriteLine("enter length");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter width");
                double width = Convert.ToDouble(Console.ReadLine());
                area = areaOfRectangle(width, length);
            }
            if (choice == 4)
            {
                Console.WriteLine("enter base");
                double Base = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter perpendicular height");
                double perpendicularHeight = Convert.ToDouble(Console.ReadLine());
                area = areaOfPentagon(Base, perpendicularHeight);
            }
            if (choice == 5)
            {
                Console.Write("enter side length");
                double sideLength = Convert.ToDouble(Console.ReadLine());
                area = areaOfOctagon(sideLength);
            }

            Console.WriteLine("area is " + area + " cm^2");
        }

        static double areaOfCircle(double radius)
        {
            return radius * radius * Math.PI;
        }

        static double areaOfTriangle(double width, double height)
        {
            return (width * height) / 2;
        }

        static double areaOfRectangle(double width, double length)
        {
            return width * length;
        }

        static double areaOfPentagon(double Base, double perpendicularHeight)
        { 
            return 5/2 * Base * perpendicularHeight;
        }

        static double areaOfOctagon(double sideLength)
        { 
            return 2 * (1 + Math.Sqrt(2)) * sideLength * sideLength;
        }
    }
}
