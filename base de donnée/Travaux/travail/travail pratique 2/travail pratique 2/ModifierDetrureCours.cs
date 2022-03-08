using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace travail_pratique_2
{
    public partial class ModifierDetrureCours : Form
    {
        ManagerCours managerCours = new ManagerCours();
        string mixte;
        SqlDataReader readerDeCours;
        BindingSource bindingsourceAfficheCategorie = new BindingSource();
        BindingSource bindingsourceAfficheCours = new BindingSource();
        internal ManagerCours ManagerCours { get => managerCours; set => managerCours = value; }
        public string Mixte { get => mixte; set => mixte = value; }
        public BindingSource BindingsourceAfficheCategorie { get => bindingsourceAfficheCategorie; set => bindingsourceAfficheCategorie = value; }
        public BindingSource BindingsourceAfficheCours { get => bindingsourceAfficheCours; set => bindingsourceAfficheCours = value; }
        public SqlDataReader ReaderDeCours { get => readerDeCours; set => readerDeCours = value; }

        public ModifierDetrureCours()
        {
            InitializeComponent();
        }
        private void ModifierDetruireCours_Load(object sender, EventArgs e)
        {
            using (SqlDataReader readerDeCategorie = ManagerCours.afficherLesCategories())
            {
                BindingsourceAfficheCategorie.DataSource = readerDeCategorie;
                cmb_Categorie.ValueMember = "no_categorie";
                cmb_Categorie.DisplayMember = "categorie";
                cmb_Categorie.DataSource = BindingsourceAfficheCategorie;
            }
            using ( readerDeCours = ManagerCours.afficherLesCours())
            {
                BindingsourceAfficheCours.DataSource = readerDeCours;
                cmb_RechercheEntreprise.ValueMember = "no_cours";
                cmb_RechercheEntreprise.DisplayMember = "cours";
                cmb_RechercheEntreprise.DataSource = BindingsourceAfficheCours;
            }

            cmb_Categorie.Text = "";
            cmb_RechercheEntreprise.Text = "";
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (rad_Oui.Checked == true)
                {
                    Mixte = "oui";
                }
                else if (rad_Non.Checked == true)
                {
                    Mixte = "non";
                }

                ManagerCours.modifierCours(20, textBox1.Text, textBox3.Text, Mixte, cmb_Categorie.SelectedIndex);
                MessageBox.Show("Le cours a bien été mofifié avec succès");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Le cours n'a pas bien été modifié");
                MessageBox.Show(ex.Message);
               
            }

        }
        private void btn_Detruire_Click(object sender, EventArgs e)
        {
            try
            {
                ManagerCours.detruireCours(cmb_RechercheEntreprise.SelectedIndex);
                MessageBox.Show("Le cours a bien été détruit avec succès");
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le cours n'a pas bien été détruit");
                MessageBox.Show(ex.Message);
            }
          
            cmb_Categorie.Text = "";
            cmb_RechercheEntreprise.Text = "";
        }

        private void btn_AjouterCategorie_Click(object sender, EventArgs e)
        {
            AjouterUneCategorie ajouterUneCategorie = new AjouterUneCategorie();
            ajouterUneCategorie.ShowDialog();
        }

        private void cmb_RechercheEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    ManagerCours.afficherInformationCours(cmb_RechercheEntreprise.SelectedIndex);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
    }
}
