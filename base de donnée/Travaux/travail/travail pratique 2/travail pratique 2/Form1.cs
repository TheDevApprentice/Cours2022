using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travail_pratique_2
{
    public partial class Form1 : Form
    {
        int nbHeure;
        int nomDuCours;

        ManagerCours managerCours = new ManagerCours();
        BindingSource bindingsourceAfficheCategorie = new BindingSource();
        string mixte;
        internal ManagerCours ManagerCours { get => managerCours; set => managerCours = value; }
        public string Mixte { get => mixte; set => mixte = value; }
        public int NbHeure { get => nbHeure; set => nbHeure = value; }
        public int NomDuCours { get => nomDuCours; set => nomDuCours = value; }
  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfficherLesCategories(); 

            txtNomDuCours.Clear();
            txtNbHeure.Clear();
            cmbListeCategorie.Text = "";
        }
        private void AfficherLesCategories()
        {
            using (SqlDataReader readerDeCategorie = ManagerCours.afficherLesCategories())
            {
                bindingsourceAfficheCategorie.DataSource = readerDeCategorie;
                cmbListeCategorie.ValueMember = "no_categorie";
                cmbListeCategorie.DisplayMember = "categorie";
                cmbListeCategorie.DataSource = bindingsourceAfficheCategorie;
            }
        }
        private void btn_AjoutCategorie_Click(object sender, EventArgs e)
        {
            AjouterUneCategorie ajouterUneCategorie = new AjouterUneCategorie();
            ajouterUneCategorie.ShowDialog();
            AfficherLesCategories();
        }
        private void txtNbHeure_TextChanged(object sender, EventArgs e)
        {
            
            bool sucessHeure = int.TryParse(txtNbHeure.Text, out int heure);
            if (sucessHeure)
            {
                NbHeure = heure;
            }
            else
            {
                txtNbHeure.Text = " ";
            }
        }
        private void txtNomDuCours_TextChanged(object sender, EventArgs e)
        {

            bool sucessNomDuCours = int.TryParse(txtNomDuCours.Text, out int nom);
            if (!sucessNomDuCours)
            {
                NomDuCours = nom;
            }
            else
            {
                txtNomDuCours.Text = " ";
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int categorie;
            int mixte;
            
            try
            {
                if (radioButton_Oui.Checked == true)
                {
                    Mixte = "oui";
                }
                else if (radioButton_Non.Checked == true)
                {
                    Mixte = "non";
                }
                ManagerCours.ajouterCours(NomDuCours.ToString(), NbHeure.ToString(), Mixte, int.Parse(cmbListeCategorie.SelectedValue.ToString()));
                MessageBox.Show("L'ajout du cours a été effectué avec succès");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'ajout du cours n'a pas été effectué avec succès");
                MessageBox.Show(ex.Message);
               
            }
           
            txtNomDuCours.Clear();
            txtNbHeure.Clear();
            radioButton_Non.Checked = false;
            radioButton_Oui.Checked = false;
            cmbListeCategorie.SelectedValue = "";
        }


        private void btn_ModifierCours_Click(object sender, EventArgs e)
        {
            ModifierDetrureCours modifierDetrureCours = new ModifierDetrureCours();
            modifierDetrureCours.ShowDialog(); 
        }

        private void btn_ModifierDetruireCategorie_Click(object sender, EventArgs e)
        {
            ModifierDetruireCategorie modifierDetruireCategorie = new ModifierDetruireCategorie();
            modifierDetruireCategorie.ShowDialog();
        }

     
    }
}
