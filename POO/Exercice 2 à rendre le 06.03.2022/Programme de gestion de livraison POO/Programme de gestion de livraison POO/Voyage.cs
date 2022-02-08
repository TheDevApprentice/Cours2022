using System;
using System.Collections.Generic;
using System.Text;

namespace Programme_de_gestion_de_livraison_POO
{
    class Voyage
    {
        int id;
        DateTime date;
        string camionneur;
        string camion;
        float distance;
        
        public int Id { get => id; set => id = value++; }
        public DateTime Date { get => date; set => date = value; }
        public string Camionneur { get => camionneur; set => camionneur = value; }
        public string Camion { get => camion; set => camion = value; }
        public float Distance { get => distance; set => distance = value; }

        public Voyage(int id, DateTime date, string camionneur, string camion, float distance)
        {
            Id = id;
            Date = date;
            Camionneur = camionneur;
            Camion = camion;
            Distance = distance;  
        }
    }

    
}
