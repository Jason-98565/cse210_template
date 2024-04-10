using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapt = new List<Shape>();
        Square sqar = new Square("red",9);
        shapt.Add(sqar);

        Rectangle rect = new Rectangle("blueu",3,4);
        shapt.Add(rect);

        Circle circ = new Circle("Leapord Print",5);    
        shapt.Add(circ);
        foreach (Shape sharp in shapt)
        {
            Console.WriteLine(sharp.GetArea());
            Console.WriteLine(sharp.getColor());
        }
    }
}