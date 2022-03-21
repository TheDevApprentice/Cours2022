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
        int no_categorie; 
        ManagerCours managerCours = new ManagerCours();
        BindingSource bindingsourceAfficheCategorie = new BindingSource();
        internal ManagerCours ManagerCours { get => managerCours; set => managerCours = value; }
        public int No_categorie { get => no_categorie; set => no_categorie = value; }

        public ModifierDetruireCategorie()
        {
            InitializeComponent();
        }
        private void ModifierDetruireCategorie_Load(object sender, EventArgs e)
        {
            AfficherLesCategories();

            EffacerTextBox();
           
        }
        
        private void btn_Detruire_Click(object sender, EventArgs e)
        {
            if (txt_ModifierCategorie.Text != "" || cmb_RechercheCategorie.Text != " ")
            {
                No_categorie = int.Parse(cmb_RechercheCategorie.SelectedValue.ToString());
                try
                {
                    ManagerCours.detruireCategorie(No_categorie);
                    MessageBox.Show("La catégorie a bien été détruit avec succès");
         
                    EffacerTextBox();

                   
                }
                catch (Exception)
                {
                    MessageBox.Show("Impossible de supprimer une catégorie actuellement relié à un cours de natation");

                    EffacerTextBox();
                }

               
            }
            else
            {
                MessageBox.Show("La catégorie n'a pas bien été détruit");

                EffacerTextBox();

            }
        }

        private void EffacerTextBox()
        {
            cmb_RechercheCategorie.SelectedValue = "";
            txt_ModifierCategorie.Clear();
        }
        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            if (txt_ModifierCategorie.Text != "" || cmb_RechercheCategorie.Text != "")
            {
                No_categorie = int.Parse(cmb_RechercheCategorie.SelectedValue.ToString());
                try
                {
                    ManagerCours.modifierCategorie(No_categorie, txt_ModifierCategorie.Text);
                    MessageBox.Show("La catégorie a bien été modifié avec succès");
                    EffacerTextBox();
                }
                catch (Exception )
                {
                   
                }

            }
            else
            {
                MessageBox.Show("la catégorie n'a pas bien été modifié");
                EffacerTextBox();
            }
        }
        private void AfficherLesCategories()
        {
            using (SqlDataReader readerDeCategorie = ManagerCours.afficherLesCategories())
            {
                bindingsourceAfficheCategorie.DataSource = readerDeCategorie;
                cmb_RechercheCategorie.ValueMember = "no_categorie";
                cmb_RechercheCategorie.DisplayMember = "categorie";
                cmb_RechercheCategorie.DataSource = bindingsourceAfficheCategorie;
            }
        }
        private void cmb_RechercheCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ModifierCategorie.Text = cmb_RechercheCategorie.Text.Trim(' ');
        }
    }
}
