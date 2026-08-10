public class Circulo
{
    public double Raio { get; set;}

    public Circulo (double raio)
    {
        Raio = raio;
    }

    public double Area()
    {
        return Math.PI * Raio * Raio;
    }
    public double Perimetro()
    {
        return 2 * Math.PI * Raio;
    }

    public void Exibir()
    {
        Console.WriteLine(" Raio : " + Raio);
        Console.WriteLine("Área : " + Area()) ; 
        Console.WriteLine("Perímetro : " + Perimetro()); 

    }
}


