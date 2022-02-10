﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programme_de_gestion_de_livraison_POO
{
    class Camionneur
    {
        List<Camionneur> ListeCamionneurs = new List<Camionneur>();

        string prenom;
        string nom;

        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }

        public Camionneur(string prenom,string nom)
        {
             Prenom = prenom;
             Nom = nom;
        }
        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
    }
}
