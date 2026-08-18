using System;

class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro(" ABC1234 ", "Onix", 43, 40);
        Moto moto = new Moto(" XYZ5678 ", "CG160", 18, 11);
        Caminhao caminhao = new Caminhao(" TRK9999 ", " Volvo FH ", 300, 5, 9);

        Frota f = new Frota();
        f.AdicionarVeiculo(carro);
        f.AdicionarVeiculo(moto);
        f.AdicionarVeiculo(caminhao);

        Console.WriteLine(" Viagem 1 : 200km ");
        f.RealizarViagem(200);

        Console.WriteLine("\nViagem 2: mais 300km (possivel falta de combustivel)");
        f.RealizarViagem(300);
    }
}