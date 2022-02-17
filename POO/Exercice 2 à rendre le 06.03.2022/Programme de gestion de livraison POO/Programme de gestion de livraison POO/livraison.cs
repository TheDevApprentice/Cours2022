namespace Programme_de_gestion_de_livraison_POO
{
    class livraison
    {
        int poids;
        int volume;

        public int Volume { get => volume; set => volume = value; }

        public int Poids { get => poids; set => poids = value; }


        public livraison(int poids, int volume)
        {
            Poids = poids;
            Volume = volume;
        }
        public livraison(livraison livraisonAcopier)
        {
            Poids = livraisonAcopier.Poids;
            Volume = livraisonAcopier.Volume;
        }
        public override string ToString()
        {
            return "Livraison de " + Poids + "  LB " + " avec un volume de  " + Volume;
        }


    }
}
