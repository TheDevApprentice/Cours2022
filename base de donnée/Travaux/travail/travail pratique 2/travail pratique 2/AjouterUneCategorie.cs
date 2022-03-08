using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace travail_pratique_2
{
    public partial class AjouterUneCategorie : Form
    {
        public AjouterUneCategorie()
        {
            InitializeComponent();
        }

        private void btn_AjouterCategorie_Click(object sender, EventArgs e)
        {
            ManagerCours managerCours = new ManagerCours();

            try
            {
                managerCours.ajouterCategorie(txtAjoutCategorie.Text);
                MessageBox.Show("L'ajout de la categorie a été effectué avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'ajout de la categorie n'a pas été effectué avec succès");
                MessageBox.Show(ex.Message);
            }

            txtAjoutCategorie.Clear();
            
        }
    }
}
