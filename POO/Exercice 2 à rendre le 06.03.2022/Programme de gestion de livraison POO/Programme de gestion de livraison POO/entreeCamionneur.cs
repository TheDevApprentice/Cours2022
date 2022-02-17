using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Programme_de_gestion_de_livraison_POO
{
    public partial class entreeCamionneur : Form
    {

        Camionneur newCamionneur;
        List<Camionneur> ListeCamionneurs = new List<Camionneur>();

        string nom; 
        string prenom;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        internal Camionneur NewCamionneur { get => newCamionneur; set => newCamionneur = value; }
        internal List<Camionneur> ListeCamionneur { get => ListeCamionneurs; set => ListeCamionneurs = value; }

        public entreeCamionneur()
        {
            InitializeComponent();
        }
        
        private void btn_validerEntreeCamionneur_Click(object sender, EventArgs e)
        {
            Nom = txt_entreeNom.Text;
            Prenom = txt_entreePrenom.Text;
            NewCamionneur = new Camionneur(Nom, Prenom);

            ListeCamionneurs.Add(NewCamionneur);

            txt_entreeNom.Clear();
            txt_entreePrenom.Clear(); 

            this.Close(); 
        }

      

      
    }
}
