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

        static double areaOfOctogon(double sideLength)
        { 
            return 2 * (1 + Math.Sqrt(2)) * sideLength * sideLength;
        }

    }
}
