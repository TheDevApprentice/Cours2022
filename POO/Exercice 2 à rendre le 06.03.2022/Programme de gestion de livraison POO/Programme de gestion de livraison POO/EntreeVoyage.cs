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
            try
            {
                int resultDestination;
         
                bool sucessNom = int.TryParse(txt_entreeDestiantion.Text, out resultDestination);

                if (sucessNom == false)
                {
                    NomDestination = txt_entreeDestiantion.Text;

                    NouveauVoyage = new Voyage(Id++, NomDestination);

                    ListeVoyage.Add(NouveauVoyage);

                    txt_entreeDestiantion.Clear();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ceci n'est pas une chaine de characteres, en revanche si vous voulez apporter un renseigment important mais unique que vous souhaiter communiqué avec le lecteur de la commande, il est possible de rajouter " +
                        "des +, dans le cas où vous souhaiterais renseigner des chiffres");
                }
            }
            catch (Exception)
            {

                throw;
            }

          
        }
    }
}
