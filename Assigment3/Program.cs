using Assigment3;

// Create a Sphere with radius 5
var sphere = new Sphere(5);
Console.WriteLine("Sphere:");
Console.WriteLine($"Area: {sphere.CalculateArea():F3}");
Console.WriteLine($"Volume: {sphere.CalculateVolume():F3}");
Console.WriteLine();

// Create a Cylinder with radius 3 and height 7
var cylinder = new TestsCylinder(3, 7);
Console.WriteLine("Cylinder:");
Console.WriteLine($"Area: {cylinder.CalculateArea():F3}");
Console.WriteLine($"Volume: {cylinder.CalculateVolume():F3}");
Console.WriteLine();

// Create a Rectangle with length 4 and width 8
var rectangle = new TestsRectangle(4, 8);
Console.WriteLine("Rectangle:");
Console.WriteLine($"Area: {rectangle.CalculateArea():F3}");
// Rectangle is a 2D shape, so volume is 0
Console.WriteLine($"Volume: {rectangle.CalculateVolume():F3}");
Console.WriteLine();

// Create a Cube with side 4
var cube = new TestsCube(4);
Console.WriteLine("Cube:");
Console.WriteLine($"Area: {cube.CalculateArea():F3}");
Console.WriteLine($"Volume: {cube.CalculateVolume():F3}");

namespace Assigment3
{
    public interface IShape
    {
        double CalculateArea();
        double CalculateVolume();
    }
    
    public class TestsCube(double side) : IShape
    {
        private readonly double side = side > 0 ? side : throw new ArgumentException("The side must be positive number!");

        public double CalculateArea()
        {
            return 6 * Math.Pow(side, 2);
        }

        public double CalculateVolume()
        {
            return Math.Pow(side, 3);
        }

    }
    
    public class TestsRectangle(double length, double width) : IShape
    {
        private readonly double length = length > 0 ? length : throw new ArgumentException("The length must be positive number!");
        private readonly double width = width > 0 ? width : throw new ArgumentException("The width must be positive number!");

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculateVolume()
        {
            return 0;
        }
    }
    
    public class TestsCylinder(double radius, double height) : IShape
    {
        private readonly double radius = radius > 0 ? radius : throw new ArgumentException("The radius must be positive number!");
        private readonly double height = height > 0 ? height : throw new ArgumentException("The height must be positive number!");

        public double CalculateArea()
        {
            return 2 * Math.PI * radius * (radius + height);
        }

        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

    }
    
    public class Sphere(double radius) : IShape
    {
        private readonly double radius = radius > 0 ? radius : throw new ArgumentException("The radius must be positive number!");

        public double CalculateArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        public double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }
    
}

