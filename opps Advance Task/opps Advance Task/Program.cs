using System;


public interface Shape
{
    double GetArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double length, width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double GetArea()
    {
        return length * width;
    }
}

public class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double GetArea()
    {
        return side * side;
    }
}


class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);
        Shape square = new Square(4);

        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        Console.WriteLine($"Square Area: {square.GetArea()}");
    }
}

