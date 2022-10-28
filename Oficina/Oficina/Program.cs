using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Models.Carro corcel = new Models.Carro("Chevrolet", "2");
        Pneu pneuNovo = new Pneu(16, "Michelan");
        corcel.LigarDesligar();
        
        for(int i=0; i <= 10; i++)
        {
            corcel.Acelerar(120);
            corcel.Frear(120);
        }

        corcel.TrocarPneu(pneuNovo);
        corcel.Acelerar(120);
        corcel.Frear(120);
        corcel.Exibir();
        

     }
}