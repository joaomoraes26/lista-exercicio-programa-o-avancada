using System;
using System.Runtime.CompilerServices;

public class ContaBancaria
{
    private string Nome;
    private int NumeroConta;
    private double Saldo; 


    public ContaBancaria(string nome,int numeroConta, double saldo)
    {
        this.Nome = nome;
        this.NumeroConta = numeroConta;
        this.Saldo = saldo;
    
    }

    public double getSaldo()
    {
        return Saldo;
    }

    public void depositar(double valor)
    {
        if(valor <= 0)
        {
            Console.WriteLine("Valor inexistente! ");
        }
        else
        {
            Saldo += valor;
        }
    }

    public void Sacar(double valor)
    {
        if(valor <= 0)
        {
            Console.WriteLine(" Não é possivel realizar o depósito");
        }
        else
        {
            Saldo -= valor;
        }
    }

    public double ObterSaldo()
    {
        return Saldo;
    }

    public int ObterNumero()
    {
        return NumeroConta;
    }
    
    public string ObterNomeCliente()
    {
        return Nome;
    }

    public void Exibir()
    {
        Console.WriteLine(" Nome : " + Nome);
        Console.WriteLine(" NumeroConta : " + NumeroConta);
        Console.WriteLine(" Saldo : " + Saldo); 
    }

}