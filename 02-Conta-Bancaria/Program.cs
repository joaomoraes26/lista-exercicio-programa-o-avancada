class Program
{
    static void Main(string [] args)
    {
        ContaBancaria C1 = new ContaBancaria(2610, "Pedro", 1000);

        C1.Depositar(500);

        C1.Sacar(250);

        C1.ExibirSaldo();
    }
}