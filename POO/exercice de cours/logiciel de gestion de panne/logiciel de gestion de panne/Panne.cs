using System;
using System.Collections.Generic;
using System.Text;

namespace logiciel_de_gestion_de_panne
{
    class Panne
    {
        int clients;
        DateTime dateDebut;
        DateTime dateUpdate;
        EtatPanne etat;


        public int Clients { get => clients; set => clients = value; }

        public EtatPanne Etat { get => etat;

            set
            {
                if (Enum.IsDefined(typeof(EtatPanne), value))
                {
                    etat = value;
                    dateUpdate = DateTime.Now;
                }
               
            }
        }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateUpdate { get => dateUpdate; set => dateUpdate = value; }

        
        public Panne(int clients)
        {
            Clients = clients;
            DateDebut = DateTime.Now;
            Etat = EtatPanne.AnalysesRequise;
        }
        public Panne(Panne panneACopier)
        {
            Clients = panneACopier.Clients;
            DateDebut = panneACopier.DateDebut;
            dateUpdate = panneACopier.dateUpdate;
            
        }


        public override string ToString()
        {
            return DateDebut + " , " + "Nombre de clients : " + Clients + " , " + "Etat : " + Etat + " ," +"Dernière Maj : " + DateUpdate;
        }

    }

  
}
