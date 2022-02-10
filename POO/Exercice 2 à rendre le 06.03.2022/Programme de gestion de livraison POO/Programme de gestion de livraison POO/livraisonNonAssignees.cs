﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programme_de_gestion_de_livraison_POO
{

    class livraisonNonAssignees
    {
        List<livraisonNonAssignees> ListeLivraisonNonAssignees = new List<livraisonNonAssignees>();

        int poids;
        int volume;

        public int Volume { get => volume; set => volume = value; }

        public int Poids { get => poids; set => poids = value; }

        public livraisonNonAssignees(int poids, int volume)
        {
            Poids = poids;
            Volume = volume;
        }
        public override string ToString()
        {
            return "Livraison de " + Poids + "  LB " + " avec un volume de  " + Volume;
        }
    }
}
