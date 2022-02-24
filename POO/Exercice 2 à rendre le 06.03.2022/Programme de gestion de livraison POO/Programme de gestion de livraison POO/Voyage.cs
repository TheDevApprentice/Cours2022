using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programme_de_gestion_de_livraison_POO
{
    class Voyage
    {
        Form1 form = new Form1();

        List<livraison> livraisons;

        
       
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
        internal List<livraison> Livraisons { get => livraisons; set => livraisons = value; }
        public Form1 Form { get => form; set => form = value; }

        public Voyage(int id)
        {
            Id = id++;
            Date = DateTime.Now;
            Camionneur = camionneur;
            Camion = camion;
            Distance = distance;

            Livraisons = new List<livraison>();
        }


        public override string ToString()
        {
            return "Voyage #" + Id;
        }
    }


}
