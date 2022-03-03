using System;
using System.Collections.Generic;
using System.Text;

namespace PO1_Examen_intra_h22
{
    class Voiture
    {
        string modele;
        DateTime dateHeureChangementHuile;
        int kilometrageDeLaVoiture;

        public int KilometrageDeLaVoiture { get => kilometrageDeLaVoiture; set => kilometrageDeLaVoiture = value; }
        public DateTime DateHeureChangementHuile { get => dateHeureChangementHuile; set => dateHeureChangementHuile = value; }
        public string Modele { get => modele; set => modele = value; }

        public Voiture(string modele)
        {
            KilometrageDeLaVoiture = 0;
            DateHeureChangementHuile = DateTime.Now;
            Modele = modele;
        }

        public override string ToString()
        {
            return "Modèle : " + Modele + " Kilométrage de la voiture : " + KilometrageDeLaVoiture + " Dernier changement d'huile fait : " + DateHeureChangementHuile;
        }
    }
}
