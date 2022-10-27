namespace Models
{
    public class Pneu
    {
        private string marca;
        private double dureza;
        private int aro;
        private bool furado;
        
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public double Dureza
        {
            get { return dureza; }
            set { dureza = value; }
        }
        public int Aro
        {
            get { return aro; }
            set { aro = value; }
        }
        public bool Furado
        {
            get { return furado; }
            set { furado = value; }
        }
        public Pneu(string _marca, int _aro)
        {
            Marca = _marca;
            Dureza = 100;
            Aro = _aro;
            Furado = false;
        }


    }
}