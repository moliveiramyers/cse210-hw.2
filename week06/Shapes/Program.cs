using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shapes>listOfShapes = new List<Shapes>();

        Square quadrado = new Square("blue",5);
        Console.WriteLine(quadrado.GetArea());
        listOfShapes.Add(quadrado);

        Rectangle retangulo = new Rectangle("Yellow",8,9);
        Console.WriteLine(retangulo.GetArea());
        listOfShapes.Add(retangulo);

        Circle circulo = new Circle("Black",8);
        Console.WriteLine(circulo.GetArea());
        listOfShapes.Add(circulo);
        
        foreach (Shapes item in listOfShapes)
        {
            double area = item.GetArea();
            Console.WriteLine(item.GetCoulor());
            Console.WriteLine(area);
        }
        


    }
}