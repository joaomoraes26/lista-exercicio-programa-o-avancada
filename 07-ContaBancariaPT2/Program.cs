class Program
{
    static void Main(string [] args)
    {
        ContaBancaria C1 = new ContaBancaria("Lucas", 1234, 2500);
        ContaBancaria C2 = new ContaBancaria("Matheus" , 5678 , 3000);
        ContaBancaria C3 = new ContaBancaria("Felipe" , 9012, 100000); 

        C2.ObterSaldo();

        C1.depositar(3000);

        C3.Sacar(2000);

        C2.Exibir();
        C1.Exibir();
        C3.Exibir();


    }
}