using System;

class Shape
{
    public virtual void Area()
    {
        Console.WriteLine("Area of Shape");
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override void Area()
    {
        double area = 3.14 * radius * radius;
        Console.WriteLine("Area of Circle = " + area);
    }
}

class Rectangle : Shape
{
    private double length;
    private double breadth;

    public Rectangle(double l, double b)
    {
        length = l;
        breadth = b;
    }

    public override void Area()
    {
        double area = length * breadth;
        Console.WriteLine("Area of Rectangle = " + area);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Base class reference pointing to Circle object
        Shape s;

        s = new Circle(5);
        s.Area();

        // Base class reference pointing to Rectangle object
        s = new Rectangle(6, 4);
        s.Area();

        Console.ReadLine();
    }
}