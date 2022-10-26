using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Models
{
    public class Apontador
    {
        private double tamanho;
        private string cor;
        private string material;
        private double dureza;

        public double Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public double Dureza
        {
            get { return dureza; }
            set { dureza = value; }
        }

        public Apontador(double _tamanho, string _cor, string _material)
        {
            Tamanho = _tamanho;
            Cor = _cor;
            Material = _material;
            Dureza = 100;
        }
        public void Apontar()
        {
            dureza -= 2;
        }
        public void Exibir()
        {
            Console.WriteLine("Cor: " + cor);
            Console.WriteLine("Tamanho: " + tamanho);
            Console.WriteLine("Meterial: " + Material);
            Console.WriteLine("Dureza: " + dureza);
        }
    }
}
