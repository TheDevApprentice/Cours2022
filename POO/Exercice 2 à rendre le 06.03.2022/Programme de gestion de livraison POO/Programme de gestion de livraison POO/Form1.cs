using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programme_de_gestion_de_livraison_POO
{
    public partial class Form1 : Form
    {
        List<livraisonIncluses> ListeLivraison = new List<livraisonIncluses>();
        List<livraisonNonAssignees> ListeLivraisonNonAssignees = new List<livraisonNonAssignees>();
        List<Voyage> ListeVoyages = new List<Voyage>();
        List<Camionneur> ListeCamionneurs = new List<Camionneur>();
        
        List<Camion> ListeCamions = new List<Camion>();

        BindingSource bindingSource = new BindingSource();

        livraisonIncluses livraisonAssignée;
        livraisonNonAssignees livraisonEnAttenteDAssignement;

        Voyage voyage;

        Camion camion;
        Camionneur camionneur;

        DateTime dateVoyageSelectioné;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            binding_LivraisonNonAssignees();
            binding_Livraisonsincluse();
            binding_Voyages();

            
        }
                private void binding_LivraisonNonAssignees()
                {
                    bindingSource.DataSource = ListeLivraisonNonAssignees;
                    lst_livraisonNonAssignees.DataSource = bindingSource;
                }
        
                private void binding_Livraisonsincluse()
                {
                    bindingSource.DataSource = ListeLivraison;
                    lst_livraisonIncluses .DataSource = bindingSource;
                }
                private void binding_Camion()
                {
                    bindingSource.DataSource = ListeCamions;
                    cmb_camions.DataSource = bindingSource;
                }
                private void binding_Camionneur()
                {
                    
                   
                }

        private void binding_Voyages()
        {
            bindingSource.DataSource = ListeVoyages;
            lst_voyages.DataSource = bindingSource;

        }


        private void btn_assigneLivraison_Click(object sender, EventArgs e)
        {
            

            


        }

        private void btn_directionNonAssignees_Click(object sender, EventArgs e)
        {

        }

        private void camionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void voyagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void livraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
