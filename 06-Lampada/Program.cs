class Teste
{
    static void Main(string [] args)
    {
        Lampada L1 = new Lampada(250, 120, false);

        L1.Exibir();

        L1.Ligar();
        L1.Ligar();
        L1.Ligar();
        L1.Ligar();
        L1.Ligar();
        L1.Ligar();
        L1.Ligar();
        L1.Ligar();
        L1.Ligar();
        L1.Ligar();
        
        L1.Exibir();

        L1.Desligar();

        L1.Exibir();
    }
}
