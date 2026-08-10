using System;
using System.Diagnostics.Contracts;

public class Livro
{
    public string Titulo {get; set;}
    public string Autor {get; set;}
    public int Ano {get; set;}
    public int Paginas {get; set;}
    public bool Disponivel{get; set;}

    public Livro(string titulo, string autor, int ano, int paginas, bool disponivel = true)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        Paginas = paginas;
        Disponivel = disponivel;
    }

    public bool Emprestar()
    {
        if (Disponivel == false)
        {
            Console.WriteLine("O livro nao esta disponivel para emprestimo");
            return false;
        }
        else
        {
            Disponivel = false;
            return true;
        }

    }

    public bool Devolver()
    {
        if (Disponivel == false)
        {
            Console.WriteLine("O livro foi devolvido/ esta disponivel");
        }
        Disponivel = true;
        return true;
    }
    
    public bool EstaDisponivel()
    {
         return Disponivel;
    }    

    public void Exibir()
    {
        Console.WriteLine("Titulo : " + Titulo);
        Console.WriteLine("Autor : " + Autor);
        Console.WriteLine("Ano de Publicação : " + Ano);
        Console.WriteLine("Numero de Paginas : " + Paginas);
        Console.WriteLine("O livro esta disponivel ? " + Disponivel);
    }
}