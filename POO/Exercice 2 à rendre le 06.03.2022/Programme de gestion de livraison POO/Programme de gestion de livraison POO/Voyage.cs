using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programme_de_gestion_de_livraison_POO
{
    class Voyage
    {
        Form1 form = new Form1();

        int id;
        string nom; 
        DateTime date;
        string camionneur;
        Camion camion;
        float distance;
        List<livraison> livraisons = new List<livraison>();
        livraison objetLivraison;
        public int Id
        {
            get => id; set
            {
                id = value;
            }
        }
        public DateTime Date { get => date; set => date = value; }
        public string Camionneur { get => camionneur; set => camionneur = value; }
        public Camion Camion { get => camion; set => camion = value; }
        public float Distance { get => distance; set => distance = value; }
        internal List<livraison> Livraisons { get => livraisons; set => livraisons = value; }
        public Form1 Form { get => form; set => form = value; }
        public string Nom { get => nom; set => nom = value; }
        internal livraison ObjetLivraison { get => objetLivraison; set => objetLivraison = value; }

        public Voyage(int id, string nom)
        {
            Id = id;
            Nom = nom;
            Date = DateTime.Now;
            Camionneur = camionneur;
            Camion = camion;
            Distance = distance;

            Livraisons = new List<livraison>();
        }


        public override string ToString()
        {
            return "Voyage #" + Id + " Direction : " + Nom;
        }
    }


}
