using System;

public class Lampada
{
    public bool Estado {get; set;}
    public double Potencia {get; set;}
    public double Voltagem{get; set;}
    public bool Queimada {get; set;}

    public Lampada(double potencia, double voltagem, bool estado = false)
    {
        Estado = estado;
        Potencia = potencia;
        Voltagem = voltagem;
    }

    public void Ligar()
    {
        if (Queimada)
        {
            Console.WriteLine("A lampada esta queimada, nao e possivel ligar");
        }
        else
        {
            Random random = new Random();
            int n = random.Next(1,101);

            if( n <= 15)
            {
                Queimada = true;
                Estado = false;
                Console.WriteLine("A lampada queimou!");
            }
            else
            {
             Estado = true;
             Console.WriteLine(" A lampada foi acesa ");
            }
        }
    }
    public void Desligar()
    {
        Estado = false;
        Console.WriteLine(" A lampada foi apagada ");
    }

    public bool Ligada()
    {
        return Estado;
    }

    public void Exibir()
    {
        Console.WriteLine(" A lampada esta ligada ? " +  Ligada());
        Console.WriteLine(" Qual a potencia da lampada ? " +  Potencia);
        Console.WriteLine(" Qual a voltagem da lampada ? " +  Voltagem);

    }

}


    

