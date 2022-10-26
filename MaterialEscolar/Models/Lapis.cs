namespace Models
{
    public class Lapis
    {
        private string dureza;
        private bool apontado;
        private int percentualGrafite;

        public string Dureza
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

        public Lapis(string _dureza, bool _apontado, int _percentualGrafite) // Criando um construtor 
        {
            Dureza = _dureza;
            Apontado = _apontado;
            PercentualGrafite = _percentualGrafite;
        }
        public void Exibir()
        {
            Console.WriteLine("Dureza: " + dureza);
            Console.WriteLine("Percentual de Grafite: " + percentualGrafite);
        }
    }
}