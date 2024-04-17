/** 
 * This program calculates and displays information about different types of quadrilaterals: Trapezoid, Parallelogram, Rectangle, and Square.
 * For each type of quadrilateral, it prompts the user to input the coordinates of its vertices and then calculates and displays:
 * - The coordinates of the vertices.
 * - The height, base(s), and area of the quadrilateral.
 * For squares, it also calculates the side length and additional information specific to squares.
 */

using System;

class Quadrilateral
{
    static void Main()
    {
        
        Console.WriteLine("Trapezoid:");
        Trapezoid trapezoid = new Trapezoid(1.2, 1.4, 5.6, 3.8, 4.2, 8.9, 1.2, 4.1);
        trapezoid.DisplayInfo();
        Console.WriteLine();

        // Parallelogram
        Console.WriteLine("Parallelogram:");
        Parallelogram parallelogram = new Parallelogram(4.0, 2.0, 7.0, 5.0, 2.0, 3.0, 7.0, 1.0);
        parallelogram.DisplayInfo();
        Console.WriteLine();

        // Rectangle
        Console.WriteLine("Rectangle:");
        Rectangle rectangle = new Rectangle(7.0, 4.0, 3.0, 4.0, 3.0, 2.0, 1.0, 2.0);
        rectangle.DisplayInfo();
        Console.WriteLine();

        // Square
        Console.WriteLine("Square:");
        Square square = new Square(4.0, 0.0, 8.0, 0.0, 8.0, 4.0, 4.0, 4.0);
        square.DisplayInfo();
    }
}

class Quadrilateral
{
    protected double x1, y1, x2, y2, x3, y3, x4, y4;

    public Quadrilateral(double x1, double y1, double x2, double y2,
                         double x3, double y3, double x4, double y4)
    {
        this.x1 = x1; this.y1 = y1;
        this.x2 = x2; this.y2 = y2;
        this.x3 = x3; this.y3 = y3;
        this.x4 = x4; this.y4 = y4;
    }
}

class Trapezoid : Quadrilateral
{
    public Trapezoid(double x1, double y1, double x2, double y2,
                     double x3, double y3, double x4, double y4)
        : base(x1, y1, x2, y2, x3, y3, x4, y4)
    {
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Points: Coordintes: X_Cord: {x1}\nY_Cord: {y1}\nCoordintes: X_Cord: {x2}\nY_Cord: {y2}\nCoordintes: X_Cord: {x3}\nY_Cord: {y3}\nCoordintes: X_Cord: {x4}\nY_Cord: {y4}\n");
        double height = Math.Abs(y2 - y1);
        double base1 = Math.Abs(x4 - x3);
        double base2 = Math.Abs(x2 - x1);
        double area = 0.5 * (base1 + base2) * height;
        Console.WriteLine($"height: {height} base1: {base1} Base2: {base2} Area:{area}\n");
    }
}

class Parallelogram : Quadrilateral
{
    public Parallelogram(double x1, double y1, double x2, double y2,
                         double x3, double y3, double x4, double y4)
        : base(x1, y1, x2, y2, x3, y3, x4, y4)
    {
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Points: Coordintes: X_Cord: {x1}\nY_Cord: {y1}\nCoordintes: X_Cord: {x2}\nY_Cord: {y2}\nCoordintes: X_Cord: {x3}\nY_Cord: {y3}\nCoordintes: X_Cord: {x4}\nY_Cord: {y4}\n");
        double height = Math.Abs(y2 - y1);
        double base1 = Math.Abs(x3 - x1);
        double base2 = Math.Abs(x4 - x2);
        double area = base1 * height;
        Console.WriteLine($"height: {height} base1: {base1} Base2: {base2} Area:{area}\n");
    }
}

class Rectangle : Parallelogram
{
    public Rectangle(double x1, double y1, double x2, double y2,
                     double x3, double y3, double x4, double y4)
        : base(x1, y1, x2, y2, x3, y3, x4, y4)
    {
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Points: Coordintes: X_Cord: {x1}\nY_Cord: {y1}\nCoordintes: X_Cord: {x2}\nY_Cord: {y2}\nCoordintes: X_Cord: {x3}\nY_Cord: {y3}\nCoordintes: X_Cord: {x4}\nY_Cord: {y4}\n");
        double height = Math.Abs(y3 - y1);
        double base1 = Math.Abs(x2 - x1);
        double base2 = Math.Abs(x3 - x1);
        double area = base1 * height;
        Console.WriteLine($"height: {height} base1: {base1} Base2: {base2} Area:{area}\n");
        height = Math.Abs(y3 - y1);
        double length = Math.Abs(x2 - x1);
        area = length * height;
        Console.WriteLine($"height: {height} Length: {length} Area:{area}\n");
    }
}

class Square : Rectangle
{
    public Square(double x1, double y1, double x2, double y2,
                  double x3, double y3, double x4, double y4)
        : base(x1, y1, x2, y2, x3, y3, x4, y4)
    {
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Points: Coordintes: X_Cord: {x1}\nY_Cord: {y1}\nCoordintes: X_Cord: {x2}\nY_Cord: {y2}\nCoordintes: X_Cord: {x3}\nY_Cord: {y3}\nCoordintes: X_Cord: {x4}\nY_Cord: {y4}\n");
        double height = Math.Abs(y3 - y1);
        double base1 = Math.Abs(x4 - x3);
        double base2 = Math.Abs(x2 - x1);
       
               double area = base1 * height;
        Console.WriteLine($"height: {height} base1: {base1} Base2: {base2} Area:{area}\n");
        height = Math.Abs(y3 - y1);
        double length = Math.Abs(x2 - x1);
        area = length * height;
        Console.WriteLine($"height: {height} Length: {length} Area:{area}\n");

        // Additional information specific to Square
        double sideLength = Math.Abs(x2 - x1);
        area = sideLength * sideLength;
        Console.WriteLine($"height: {height} Sides: {sideLength} Area:{area}\n");
    }
}
