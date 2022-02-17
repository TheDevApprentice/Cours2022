namespace Programme_de_gestion_de_livraison_POO
{
    class Camion
    {
        int poids;
        int volume;

        public int Volume { get => volume; set => volume = value; }

        public int Poids { get => poids; set => poids = value; }

        public Camion(int volume, int poids)
        {
            Poids = poids;
            Volume = volume;
        }
        public override string ToString()
        {
            return "Camion poids : " + Poids.ToString() + ", volume de : " + Volume.ToString();
        }

    }


}
