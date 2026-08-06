using System;

public class Retangulo
{
    public double Largura  {get; set;}
    public double Altura {get; set;}

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public double Area()
    {
        return Largura * Altura;
    }

    public double Perimetro()
    {
        return 2 * (Largura + Altura);
    }

    public void Exibir()
    {
        Console.WriteLine("Altura " + Altura);
        Console.WriteLine("Largura " + Largura);
        Console.WriteLine("Area : " + Area());
        Console.WriteLine("Perimetro: " + Perimetro());
    }

}