using System;

public class Caminhao : Veiculo
{
    protected double CargaAtual;

    public Caminhao(string placa, string modelo, double tamanhoTanque, double nivelCombustivel, double cargaAtual) 
        : base(placa, modelo, tamanhoTanque, nivelCombustivel)
    {
        CargaAtual = cargaAtual;
    }

    public override void Mover(double distancia)
    {
        double consumo = distancia / 5 + CargaAtual * 0.2; 

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