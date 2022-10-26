using Models;
internal class Program
{
    private static void Main(string[] args)
    {
        Models.Caneta caneta = new Models.Caneta("Azul", 12,12,"Bic","ouro",12.2,"2");
        caneta.Tampar();
        caneta.Escrever("André");
        caneta.Exibir();

        Models.Lapis lapis = new Models.Lapis("100%",true,100);
        lapis.Exibir();

    }
}