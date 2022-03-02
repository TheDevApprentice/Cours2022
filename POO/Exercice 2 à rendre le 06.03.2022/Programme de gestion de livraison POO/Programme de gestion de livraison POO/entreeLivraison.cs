using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programme_de_gestion_de_livraison_POO
{
    public partial class entreeLivraison : Form
    {
        livraison newLivraisonNonAssignee;
        List<livraison> listeLivraisonNonAssignees = new List<livraison>();


        int poids;
        int volume;

        public int Poids { get => poids; set => poids = value; }
        public int Volume { get => volume; set => volume = value; }
        internal livraison NewLivraison { get => newLivraisonNonAssignee; set => newLivraisonNonAssignee = value; }
        internal List<livraison> ListeLivraisonNonAssignees { get => listeLivraisonNonAssignees; set => listeLivraisonNonAssignees = value; }


        public entreeLivraison()
        {
            InitializeComponent();
        }

        private void entreeLivraison_Load(object sender, EventArgs e)
        {
       
        }

        private void btb_validateLivraisonEntree_Click(object sender, EventArgs e)
        {
            try
            {
                int resultPoids;
                int resultVolume;

                bool successPoids = int.TryParse(txt_entreePoidsLivraison.Text, out resultPoids);
                bool successVolume = int.TryParse(txt_entreeVolumeLivraison.Text, out resultVolume);

                if (successPoids == true && successVolume == true)
                {
                    Poids = resultPoids;
                    Volume = resultVolume;

                    newLivraisonNonAssignee = new livraison(Poids, Volume);
                    listeLivraisonNonAssignees.Add(newLivraisonNonAssignee);

                    txt_entreePoidsLivraison.Clear();
                    txt_entreeVolumeLivraison.Clear();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ceci n'est pas une valeur approprié.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
