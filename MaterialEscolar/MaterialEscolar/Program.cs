using Models;
internal class Program
{
    private static void Main(string[] args)
    {   //criando o objeto caneta
        Console.WriteLine("-----Caneta-----");
        Models.Caneta caneta = new Models.Caneta("Azul", 12,12,"Bic","ouro",12.2,"2");
        //caneta.Tampar();
        caneta.Escrever("André");
        caneta.Exibir();

        Console.WriteLine("\n");
        Console.WriteLine("-----Lapis-----");
        //Criando o objeto lapis
        Models.Lapis lapis = new Models.Lapis("100%");
        
        lapis.Exibir();
        lapis.Escrever("André");
        lapis.Exibir();

        Console.WriteLine("\n");
        Console.WriteLine("-----Borracha-----");

        Models.Borracha borracha = new Models.Borracha(5, "poli-isopreno");
        borracha.Exibir();

        Console.WriteLine("\n");
        Console.WriteLine("-----Apontador-----");
        Models.Apontador apontador = new Models.Apontador(10,"Vermelho","ferro");
        apontador.Exibir();

        Console.WriteLine("\n");
        Console.WriteLine("-----Caderno-----");

        Models.Caderno caderno = new Models.Caderno(10, "Caderno Novo", 12, 10.5);
        caderno.Exibir();
        caderno.Exibir();
    }
}