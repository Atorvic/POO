namespace Models
{
    public class Pneu
    {
        private string marca;
        private double dureza;
        private double aro;
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
        public double Aro
        {
            get { return aro; }
            set { aro = value; }
        }
        public bool Furado
        {
            get { return furado; }
            set { furado = value; }
        }


    }
}