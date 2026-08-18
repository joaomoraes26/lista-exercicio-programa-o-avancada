public class Carro : Veiculo
{
      public Carro (string placa,string modelo, double TamanhoTanque, double combustivel) : base( placa, modelo , TamanhoTanque, combustivel){}

    public override void Mover(double distancia)
    {
           double consumo = distancia / 13;

           if(consumo > NivelCombustivel){

            Console.WriteLine( Modelo + "Não possivel combustivel suficiente para rodar a viagem");

           }
        else
        {

           NivelCombustivel -= consumo;
           KM += distancia; 
           base.Mover(distancia);
           Console.WriteLine(Modelo + " percorreu " + distancia + " km, teve um consumo de " + consumo + " L ");
        }

    }
}