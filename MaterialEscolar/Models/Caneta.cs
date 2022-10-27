using System.Runtime;
using System.Windows.Markup;

namespace Models
{
    public class Caneta
    {
        private string cor; //criando um atribudo privato.
        private string material;
        private string marca;
        private string tipoPonta;
        private double tamanho;
        private double peso;
        private double ponta;
        private bool caida;
        private bool tampada;
        private bool estourada;
        private int percentualCarga;


        public string Cor //para ter acesso a Cor privata, tem que fazer esse esquema.
        {
            get { return cor; } // pegar informação
            set { cor = value; } // inserir informação
        }
        public double Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public bool Tampada
        {
            get { return tampada; }
            set { tampada = value; }
        }
        public int PercentualCarga
        {
            get { return percentualCarga; }
            set{ percentualCarga = value; }
        }
        public string Marca
        {
            get { return material; }
            set { material = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public double Ponta
        {
            get { return ponta; }
            set { ponta = value; }
        }
        public string TipoPonta
        {
            get { return tipoPonta; }
            set { tipoPonta = value; }
        }
        public bool Caida
        {
            get { return caida; }
            set { caida = value; }
        }
        public bool Estourada
        {
            get { return estourada; }
            set { estourada = value; }
        }
        // Criando o construtor.
        public Caneta(string _cor, double _tamanho, double _peso, string _marca, string _material, double _ponta, string _tipoPonta)
        {
            Cor = _cor;
            Tamanho = _tamanho;
            Peso = _peso;
            Marca = _marca;
            Material = _material;
            Ponta = _ponta;
            TipoPonta = _tipoPonta;
   
        }
        public void Tampar()
        {
            tampada = true;
        }
        public void Destampada()
        {
            tampada = false;
        }
        public void Escrever(string _texto)
        {
            if(tampada == true) // ou pode usar dessa outra forma. ->  if(tampada) { }
            {
                Console.WriteLine("Não pode escrever com a caneta tampada!");
                return;
            }
            Console.WriteLine(_texto);
        }
        public void Exibir()
        {
            Console.WriteLine("Cor: " + cor);
            Console.WriteLine("Tamanho: " + tamanho);
            Console.WriteLine("Peso: " + peso);

        }

    }
}