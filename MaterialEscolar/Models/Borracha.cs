using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Borracha
    {
        private double dureza;
        private double tamanho;
        private string material;

        public double Dureza
        {
            get { return dureza; }
            set { dureza = value; }
        }
        public double Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public Borracha(double _tamanho, string _material)
        {
            Dureza = 100;
            Tamanho = _tamanho;
            Material = _material;
        }
        public void Exibir()
        {
            Console.WriteLine("Dureza: " + Dureza);
            Console.WriteLine("Tamanho: " + Tamanho);
            Console.WriteLine("Material: " + Material);
        }
        public void Apagar()
        {
            dureza -= 2;
        }
    }
}
