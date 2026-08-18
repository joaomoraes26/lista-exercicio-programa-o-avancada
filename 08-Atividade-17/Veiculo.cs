using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
public class Veiculo
{
    protected string Placa;
    protected string Modelo;
    protected double NivelCombustivel;
    protected double KM;
    protected double TamanhoTanque;
    protected List<string> L = new List<string>();


    public Veiculo(string placa,string modelo,double tamanhoTanque, double nivelCombustivel)  
    {
        this.Placa = placa; 
        this.Modelo = modelo;
        this.NivelCombustivel = nivelCombustivel;
        this.TamanhoTanque = tamanhoTanque;  
    }

    public void Abastecer(double litros)
    {
        if(NivelCombustivel + litros > TamanhoTanque)
        {
            Console.WriteLine("O tanque esta cheio");
        }
        else
        {
            NivelCombustivel += litros;
            Console.WriteLine(Modelo + "abastecido. Tanque : " + TamanhoTanque);    
        }
    }

    public virtual void Mover(double distancia)
    {
        L.Add(Modelo + " andou " + distancia + " km ");
    }

   
}
 


