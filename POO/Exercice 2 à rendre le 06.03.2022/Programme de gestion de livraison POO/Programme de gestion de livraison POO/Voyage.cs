using System;

namespace Programme_de_gestion_de_livraison_POO
{
    class Voyage
    {

        livraison livraisonAassignee;

        int id;
        DateTime date;
        string camionneur;
        string camion;
        float distance;


        public int Id
        {
            get => id; set
            {
                id = value;
            }
        }
        public DateTime Date { get => date; set => date = value; }
        public string Camionneur { get => camionneur; set => camionneur = value; }
        public string Camion { get => camion; set => camion = value; }
        public float Distance { get => distance; set => distance = value; }
        internal livraison LivraisonAassignee { get => livraisonAassignee; set => livraisonAassignee = value; }

        public Voyage(int id)
        {
            Id = id++; 
        }

        public Voyage(DateTime date, string camionneur, string camion, float distance, livraison livraison)
        {
            
            Date = date;
            Camionneur = camionneur;
            Camion = camion;
            Distance = distance;

            LivraisonAassignee = new livraison(livraison);

        }

        public override string ToString()
        {
            return "Voyage #" + Id;
        }
    }


}
