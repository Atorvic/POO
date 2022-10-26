using System.Reflection.Metadata;

namespace Models
{
    public class Lapis
    {
        private string dureza; //minha variavel
        private bool apontado;
        private int percentualGrafite;

        public string Dureza //minha propriedade
        {
            get { return dureza; } // pegar informação
            set { dureza = value; } //inserir informação
        }
        public bool Apontado
        {
            get { return apontado; }
            set { apontado = value; }
        }
        public int PercentualGrafite
        {
            get { return percentualGrafite; }   
            set { percentualGrafite = value; }
        }

        public Lapis(string _dureza) // Criando um construtor 
        {
            Dureza = _dureza;
            Apontado = true;
            PercentualGrafite = 100;
        }
        public void Exibir()
        {
            Console.WriteLine("Dureza: " + dureza);
            Console.WriteLine("Percentual de Grafite: " + percentualGrafite);
        }
         public void Apontar()
         {
             if(PercentualGrafite < 5)
             {
                 Console.WriteLine("Compre outro lápis!");
                 return;
             }
             apontado = true;
             GastarGrafite(5);

         }
         public void QuebrarPonta()
         {
             if(percentualGrafite < 15)
             {
                 Console.WriteLine("Compre outro lápis");
                 return;
             }
             apontado = false;
             GastarGrafite(2);
         }
         public void Escrever(string _texto)
         {

             Console.WriteLine(_texto);
             GastarGrafite(5);
         }
         private void GastarGrafite(int _percentual) // metodo de gastarGrafite
         {
             percentualGrafite -= _percentual;
             if(percentualGrafite < 0)
             {
                 percentualGrafite = 0;
                 return;
             }

         }


    }
}