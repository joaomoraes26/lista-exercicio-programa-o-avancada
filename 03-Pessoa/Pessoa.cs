using System; 

public class Pessoa
{
    public string Nome {get; set;}
    public int Idade {get; set;}
    public string Genero {get; set;}

    public Pessoa (string nome, int idade, string genero)
    {
        Nome = nome;
        Idade = idade;
        Genero = genero;
    }

    public bool Maioridade ()
    {
        if(Idade >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ExibirInfo()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade : " + Idade);
        Console.WriteLine("Genero : " + Genero);
        Console.WriteLine("Maior de Idade ? " + Maioridade());
    }
}