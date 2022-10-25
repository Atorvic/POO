using System.Runtime;
using System.Windows.Markup;

namespace Models
{
    public class Caneta
    {
        private string cor; //criando um atribudo privato.
        private double tamanho;
        private double peso;
        private bool tampada;
        private int percentualCarga;
        private string marca;
        private string material;
        private double ponta;
        private string tipoPonta;
        private bool caida;
        private bool estourada;


        public string Cor //para ter acesso a Cor privata, tem que fazer esse esquema.
        {
            get { return cor; }
            set { cor = value; }
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

    }
}