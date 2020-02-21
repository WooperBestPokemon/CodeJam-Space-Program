﻿namespace CodeJam_SPACE
{
    class Moteur
    {
        public Moteur(string nom, double poids, double hauteur, double diametre, int consumationFuel, int thrust, double impSpecifique)
        {
            Nom = nom;
            Poids = poids;
            Hauteur = hauteur;
            Diametre = diametre;
            ConsumationFuel = consumationFuel;
            Thrust = thrust;
            ImpSpecifique = impSpecifique;
        }
        public string Nom { get; set; }
        public double Poids { get; set; } //kg
        public double Hauteur { get; set; } //M
        public double Diametre { get; set; } //M
        public double ImpSpecifique { get; set; }
        public int ConsumationFuel { get; set; } //kg/S
        public int Thrust { get; set; } //kN
    }
}
