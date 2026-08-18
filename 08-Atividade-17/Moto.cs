using System;

public class Moto : Veiculo
{
    private double limiteViagem = 250;

    public Moto(string placa, string modelo, double tamanhoTanque, double nivelCombustivel) 
        : base(placa, modelo, tamanhoTanque, nivelCombustivel) { }

    public override void Mover(double distancia)
    {
        if (distancia > limiteViagem)
        {
            Console.WriteLine(Modelo + " nao é possivel percorrer mais de " + limiteViagem + " km numa unica viagem, por questoes de seguranca");
        }
        else
        {
            double consumo = distancia / 25;

            if (consumo > NivelCombustivel)
            {
                Console.WriteLine(Modelo + " nao tem combustivel suficiente para essa viagem!");
            }
            else
            {
                NivelCombustivel -= consumo;
                KM += distancia;
                base.Mover(distancia);
                Console.WriteLine(Modelo + " percorreu " + distancia + " km, consumo: " + consumo + " L");
            }
        }
    }
}