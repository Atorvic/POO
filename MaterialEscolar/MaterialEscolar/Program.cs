internal class Program
{
    private static void Main(string[] args)
    {
        Models.Caneta caneta = new Models.Caneta();
        caneta.Cor = "azul";
        Console.WriteLine(caneta.Cor);

    }
}