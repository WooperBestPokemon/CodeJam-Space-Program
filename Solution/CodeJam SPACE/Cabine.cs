namespace CodeJam_SPACE
{
    class Cabine
    {
        public Cabine(string nom, double poids)
        {
            Nom = nom;
            Poids = poids;
        }
        public string Nom { get; set; }
        public double Poids { get; set; } //kg/S
    }
}
