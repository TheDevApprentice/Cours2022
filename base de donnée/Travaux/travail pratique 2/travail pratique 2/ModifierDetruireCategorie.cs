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
            if (txt_ModifierCategorie.Text != "" && cmb_RechercheCategorie.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("VOulez vous vraiment détuire cette Catégorie ? ", "Oui", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        No_categorie = int.Parse(cmb_RechercheCategorie.SelectedValue.ToString());
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
                else if (dialogResult == DialogResult.No)
                {
                    EffacerTextBox();
                }
            }
            else
            {
                MessageBox.Show("Il vous faut choisir une catégorie pour la supprimer");

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
                DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment modifier cette categorie ?", "Oui", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        No_categorie = int.Parse(cmb_RechercheCategorie.SelectedValue.ToString());
                        ManagerCours.modifierCategorie(No_categorie, txt_ModifierCategorie.Text);
                        MessageBox.Show("La catégorie a bien été modifié avec succès");
                        EffacerTextBox();
                    }
                    catch (Exception)
                    {

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    EffacerTextBox();
                }
             

            }
            else
            {
                MessageBox.Show("Il vous faut choisir une Catégorie pour modifier cette dernière");
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
