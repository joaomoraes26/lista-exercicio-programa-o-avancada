class Program
{
    static void Main( string [] args)
    {
        Livro L1 = new Livro("Odisseia" , "Homero" , 2026, 1024, true);

        bool r1 = L1.Emprestar();
        Console.WriteLine ("Emprestimo deu certo? " + r1);

        bool r2 = L1.Emprestar();
        Console.WriteLine ("Emprestimo deu certo? " + r2);

        L1.Devolver();

        bool disp = L1.EstaDisponivel();
        Console.WriteLine("Esta disponivel? " + disp);
    }
}
