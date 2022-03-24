using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace travail_pratique_2
{
    public partial class Form1 : Form
    {
        ManagerCours managerCours = new ManagerCours();
        int nomDuCours;
        int nbHeure;
        BindingSource bindingsourceAfficheCategorie = new BindingSource();
        string mixte;

        internal ManagerCours ManagerCours { get => managerCours; set => managerCours = value; }
        public string Mixte { get => mixte; set => mixte = value; }
        public int NomDuCours { get => nomDuCours; set => nomDuCours = value; }
        public int NbHeure { get => nbHeure; set => nbHeure = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfficherLesCategories();

            EffacerTextBox();
        }
        private void AfficherLesCategories()
        {
            try
            {
                using (SqlDataReader readerDeCategorie = ManagerCours.afficherLesCategories())
                {
                    bindingsourceAfficheCategorie.DataSource = readerDeCategorie;
                    cmbListeCategorie.ValueMember = "no_categorie";
                    cmbListeCategorie.DisplayMember = "categorie";
                    cmbListeCategorie.DataSource = bindingsourceAfficheCategorie;
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
       
        }
        private void btn_AjoutCategorie_Click(object sender, EventArgs e)
        {
            AjouterUneCategorie ajouterUneCategorie = new AjouterUneCategorie();
            ajouterUneCategorie.ShowDialog();

            AfficherLesCategories();

            EffacerTextBox();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNbHeure.Text != "" && txtNbHeure.Text != "" && cmbListeCategorie.Text != "")
            {
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

                    ManagerCours.ajouterCours(txtNomDuCours.Text, txtNbHeure.Text, Mixte, int.Parse(cmbListeCategorie.SelectedValue.ToString()));
                    MessageBox.Show("L'ajout du cours a été effectué avec succès");


                    EffacerTextBox();

                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Il faut selectionner et/ou modifier toutes les données pour que cela marche");
                EffacerTextBox();
            }
        }
        private void EffacerTextBox()
        {
            txtNomDuCours.Clear();
            txtNbHeure.Clear();
            radioButton_Non.Checked = false;
            radioButton_Oui.Checked = true;

            cmbListeCategorie.SelectedValue = "";
        }
        private void btn_ModifierCours_Click_1(object sender, EventArgs e)
        {
            ModifierDetrureCours modifierDetrureCours = new ModifierDetrureCours();
            modifierDetrureCours.ShowDialog();
        }

        private void btn_ModifierDetruireCategorie_Click_1(object sender, EventArgs e)
        {
            ModifierDetruireCategorie modifierDetruireCategorie = new ModifierDetruireCategorie();
            modifierDetruireCategorie.ShowDialog();
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
                txtNomDuCours.Text = "";
            }
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
                txtNbHeure.Text = "";
            }
        }

       
    }
}
