/* 
 * This C# program defines an abstract base class Shape and two derived classes Circle and Square.
 * Each derived class overrides the CalculateArea method to calculate the area of the respective shape.
 * The Shape class has a method DisplayInfo to print information about the shape, such as its type and area.
 * It then creates an array of Shape objects that includes instances of Circle and Square,
 * iterates through the array, and displays information about each shape.
 * Polymorphism is effectively used in this solution, making use of abstract classes and methods where appropriate.
 */

using System;

public abstract class Shape
{
    public abstract double CalculateArea();

    public void DisplayInfo()
    {
        Console.WriteLine($"Type: {GetType().Name}, Area: {CalculateArea()}");
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius) => Radius = radius;

    public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
}

public class Square : Shape
{
    public double SideLength { get; set; }

    public Square(double sideLength) => SideLength = sideLength;

    public override double CalculateArea() => Math.Pow(SideLength, 2);
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Circle(8),
            new Square(7)
        };

        foreach (Shape shape in shapes)
        {
            shape.DisplayInfo();
            Console.WriteLine();
        }
    }
}
