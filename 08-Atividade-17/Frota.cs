using System;
using System.Collections.Generic;

public class Frota
{
    private List<Veiculo> frota = new List<Veiculo>();

    public void AdicionarVeiculo(Veiculo v)
    {
        frota.Add(v);
    }

    public void RealizarViagem(double km)
    {
        foreach (Veiculo v in frota)
        {
            v.Mover(km);
        }
    }
}