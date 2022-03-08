﻿using System;
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
        int no_cours;
        int no_categorie;
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
        public int No_cours { get => no_cours; set => no_cours = value; }
        public int No_categorie { get => no_categorie; set => no_categorie = value; }

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
            //No_cours = int.Parse(cmb_RechercheEntreprise.SelectedValue.ToString());
            using ( readerDeCours = ManagerCours.afficherLesCours())
            {
                BindingsourceAfficheCours.DataSource = readerDeCours;
                cmb_RechercheEntreprise.ValueMember = "no_cours";
                cmb_RechercheEntreprise.DisplayMember = "cours";
                cmb_RechercheEntreprise.DataSource = BindingsourceAfficheCours;
            }

            cmb_Categorie.Text = "";
            txt_NbHeure.Clear();
            txt_NomDCours.Clear();
            rad_Non.Checked = false;
            rad_Oui.Checked = false;
            cmb_RechercheEntreprise.Text = "";
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            No_cours = int.Parse(cmb_RechercheEntreprise.SelectedValue.ToString());
            No_categorie = int.Parse(cmb_Categorie.SelectedValue.ToString());
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

                ManagerCours.modifierCours(No_cours, txt_NomDCours.Text, txt_NbHeure.Text, Mixte, No_categorie);
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
            No_cours = int.Parse(cmb_RechercheEntreprise.SelectedValue.ToString());
            try
            {
                ManagerCours.detruireCours(No_cours);
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
            ManagerCours managerCours = new ManagerCours();
            int No_cours = int.Parse(cmb_RechercheEntreprise.SelectedValue.ToString());
            try
            {
                using (SqlDataReader datareader = managerCours.afficherInformationCours(No_cours))
                {
                    if (datareader.Read())
                    {
                        txt_NomDCours.Text = datareader["nom_cours"].ToString();
                        txt_NbHeure.Text = datareader["nbHeureDeCours"].ToString();
                        if (datareader["mixte"].ToString() == "oui")
                        {
                            rad_Oui.Checked = true;
                        }
                        else
                        {
                            rad_Oui.Checked = false; 
                        }
                        if (datareader["mixte"].ToString() == "non")
                        {
                            rad_Oui.Checked = true;
                        }
                        else
                        {
                            rad_Non.Checked = false;
                        }
                        cmb_Categorie.Text = datareader["nom_categorie"].ToString();

                    }
                }



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
