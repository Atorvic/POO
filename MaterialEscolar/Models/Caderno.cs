using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Caderno
    {
        private int folhas;
        private string nome;
        private int materias;
        private double tamanho;

        public int Folhas
        {
            get { return folhas; }
            set { folhas = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Materias
        {
            get { return materias; }
            set { materias = value; }
        }
        public double Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public Caderno(int _folhas, string _nome, int _materias, double _tamanho)
        {
            Folhas = _folhas;
            Nome = _nome;
            Materias = _materias;
            Tamanho = _tamanho;

        }
        public void Exibir()
        {
            Console.WriteLine("Folhas: " + Folhas);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Materias: " + Materias);
            Console.WriteLine("Tamanho: " + Tamanho);
        }
    }
}
