using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exercice_sur_les_relation_nM
{
    public partial class NombreDehobby : Form
    {
        BindingSource bindingSourceEtudiants = new BindingSource();
        ManagerEtudiant managerEtudiant = new ManagerEtudiant();

        public NombreDehobby()
        {
            InitializeComponent();
        }

        private void NombreDehobby_Load(object sender, EventArgs e)
        {
            AfficherLesEtudiants();
            EffacerTextBox();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void EffacerTextBox()
        {
            cmb_etudiantNombreDeHobby.Text = "";
            btn_calcul.Text = "Calcul"; 
           
        }
        private void AfficherLesEtudiants()
        {
            try
            {
                using (SqlDataReader readerEtudiants = managerEtudiant.AfficherLesEtudiants())
                {
                    bindingSourceEtudiants.DataSource = readerEtudiants;
                    cmb_etudiantNombreDeHobby.ValueMember = "no_etudiant";
                    cmb_etudiantNombreDeHobby.DisplayMember = "noms";
                    cmb_etudiantNombreDeHobby.DataSource = bindingSourceEtudiants;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_calcul_Click(object sender, EventArgs e)
        {
            int no_etudiant = int.Parse(cmb_etudiantNombreDeHobby.SelectedValue.ToString()); 
            
            btn_calcul.Text = managerEtudiant.compteurNombreHobby(no_etudiant).ToString();

        }

        private void cmb_etudiantNombreDeHobby_SelectedIndexChanged(object sender, EventArgs e)
        {
            EffacerTextBox(); 
        }
    }
}
