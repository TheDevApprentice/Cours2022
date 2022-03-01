using System;
using System.Collections.Generic;
using System.Text;

namespace PO1_revision_examen_intra
{
    class Commande
    {
        int prix;
        string descritpion;
        bool etat; 
        public int Prix { get => prix; set => prix = value; }
        public string Descritpion { get => descritpion; set => descritpion = value; }
        public bool Etat { get => etat; set => etat = value; }

        public Commande(int prix, string descritpion)
        {
            Prix = prix;
            Descritpion = descritpion;
            Etat = false; 

        }

        public override string ToString()
        {
            return "Description  " + Descritpion + ", prix :  " + Prix + ", etat =  " + Etat;
        }

    }
    }



