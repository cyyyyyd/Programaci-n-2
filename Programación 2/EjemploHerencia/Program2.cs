using System;

public abstract class Shape
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    protected Shape(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public abstract double CalcularSuperficie();
}

public class Triangulo : Shape
{
    public Triangulo(double ancho, double alto) : base(ancho, alto) { }

    public override double CalcularSuperficie()
    {
        return (Ancho * Alto) / 2;
    }
}

public class Rectangulo : Shape
{
    public Rectangulo(double ancho, double alto) : base(ancho, alto) { }

    public override double CalcularSuperficie()
    {
        return Ancho * Alto;
    }
}

public class Circulo : Shape
{
    public Circulo(double radio) : base(radio, radio) { }

    public override double CalcularSuperficie()
    {
        return Math.PI * Ancho * Ancho; 
    }
}

// Ejemplo de uso
class Program
{
    static void Main(string[] args)
    {
        Shape[] formas = new Shape[]
        {
            new Triangulo(10, 5),
            new Rectangulo(4, 6),
            new Circulo(3)
        };

        foreach (var forma in formas)
        {
            Console.WriteLine($"Área de {forma.GetType().Name}: {forma.CalcularSuperficie():F2}");
        }
    }
}