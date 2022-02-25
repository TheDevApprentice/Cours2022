using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Programme_de_gestion_de_livraison_POO
{
    public partial class EntreeVoyage : Form
    {
        int id;

        Voyage nouveauVoyage;
        List<Voyage> listeVoyage = new List<Voyage>();
        
        string nomDestination;
  
        public int Id { get => id; set => id = value; }
        internal List<Voyage> ListeVoyage { get => listeVoyage; set => listeVoyage = value; }
        internal Voyage NouveauVoyage { get => nouveauVoyage; set => nouveauVoyage = value; }
        public string NomDestination { get => nomDestination; set => nomDestination = value; }
        public EntreeVoyage()
        {
            InitializeComponent();
        }

        private void EntreeVoyage_Load(object sender, EventArgs e)
        {

        }

        private void btn_entreeDestination_Click(object sender, EventArgs e)
        {
            NomDestination = txt_entreeDestiantion.Text;

            NouveauVoyage = new Voyage(Id++,NomDestination);

            ListeVoyage.Add(NouveauVoyage);

            txt_entreeDestiantion.Clear();

            this.Close();
        }
    }
}
