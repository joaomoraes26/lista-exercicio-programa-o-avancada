using System;


public class ContaBancaria
{
    public int NumeroConta {get; set;} 
    public string NomeTitular{get; set;}
    public double Saldo {get; set;}


    public ContaBancaria (int numeroConta, string nomeTitular, double saldoInicial)
    {
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular; 
        Saldo = saldoInicial;
    }
    
    public void Depositar (double valor)
    {   
        if(valor < 0)
        {
            Console.WriteLine("Impossivel depositar valor negativo");
        }

        else 
        {
            Saldo = Saldo + valor;
        }
    }

    public void Sacar (double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo Insuficiente");
        }
        else
        {
            Saldo = Saldo - valor;
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine("Conta: " + NumeroConta);
        Console.WriteLine("Titular: " + NomeTitular);
        Console.WriteLine("Saldo " + Saldo);
    }

}