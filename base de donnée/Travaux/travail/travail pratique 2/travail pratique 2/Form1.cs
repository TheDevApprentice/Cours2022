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
        int no_categorie; 
        ManagerCours managerCours = new ManagerCours();

        BindingSource bindingsourceAfficheCategorie = new BindingSource();
        string mixte;

        internal ManagerCours ManagerCours { get => managerCours; set => managerCours = value; }
        public string Mixte { get => mixte; set => mixte = value; }
        public int No_categorie { get => no_categorie; set => no_categorie = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlDataReader readerDeCategorie = ManagerCours.afficherLesCategories())
            {
                bindingsourceAfficheCategorie.DataSource = readerDeCategorie;
                cmbListeCategorie.ValueMember = "no_categorie, nom_categorie";
                cmbListeCategorie.DisplayMember = "categorie";
                cmbListeCategorie.DataSource = bindingsourceAfficheCategorie;
            }

            txtNomDuCours.Clear();
            txtNbHeure.Clear();

            cmbListeCategorie.Text = "";
        }
        private void btn_AjoutCategorie_Click(object sender, EventArgs e)
        {
            AjouterUneCategorie ajouterUneCategorie = new AjouterUneCategorie();
            ajouterUneCategorie.ShowDialog(); 
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            No_categorie = int.Parse(cmbListeCategorie.SelectedValue.ToString());
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
                ManagerCours.ajouterCours(txtNomDuCours.Text, txtNbHeure.Text, Mixte, No_categorie);
                MessageBox.Show("L'ajout du cours a été effectué avec succès");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'ajout du cours n'a pas été effectué avec succès");
                MessageBox.Show(ex.Message);
               
            }
           
            txtNomDuCours.Clear();
            txtNbHeure.Clear();

            cmbListeCategorie.Text = "";
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
