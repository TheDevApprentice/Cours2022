using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace travail_pratique_2
{
    public partial class ModifierDetruireCategorie : Form
    {
        ManagerCours managerCours = new ManagerCours();
        BindingSource bindingsourceAfficheCategorie = new BindingSource();
        internal ManagerCours ManagerCours { get => managerCours; set => managerCours = value; }

        public ModifierDetruireCategorie()
        {
            InitializeComponent();
        }
        private void ModifierDetruireCategorie_Load(object sender, EventArgs e)
        {
            using (SqlDataReader readerDeCategorie = managerCours.afficherLesCategories())
            {
                bindingsourceAfficheCategorie.DataSource = readerDeCategorie;
                cmb_RechercheCategorie.ValueMember = "no_categorie";
                cmb_RechercheCategorie.DisplayMember = "categorie";
                cmb_RechercheCategorie.DataSource = bindingsourceAfficheCategorie;
            }

            cmb_RechercheCategorie.Text = "";
    
        }
        private void btn_Detruire_Click(object sender, EventArgs e)
        {
            try
            {
                ManagerCours.detruireCategorie(12);
                MessageBox.Show("La catégorie a bien été détruit avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show("La catégorie n'a pas bien été détruit");
                MessageBox.Show(ex.Message);
                throw;
            }
            cmb_RechercheCategorie.Text = "";
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                ManagerCours.modifierCategorie(11, txt_ModifierCategorie.Text);
                MessageBox.Show("La catégorie a bien été modifié avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show("la catégorie n'a pas bien été modifié");
                MessageBox.Show(ex.Message);
                throw;
            }

            cmb_RechercheCategorie.Text = "";
        }

      
    }
}
