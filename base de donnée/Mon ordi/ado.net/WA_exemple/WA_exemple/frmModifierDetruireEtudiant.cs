using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WA_exemple
{
    public partial class frmModifierDetruireEtudiant : Form
    {
        public frmModifierDetruireEtudiant()
        {
            InitializeComponent();
        }
        
        private Boolean champsRempli()
        {
            if (txtCellulaire.Text != ""  && txtPrenom.Text != "" &&
                 txtNom.Text != "" )
                return true;
            else
                return false;
        }
        private void viderChamps()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtCellulaire.Text = "";
            NUDHumour.Value = 5;
            cmbRecherche.SelectedValue = "";
        }
        private void btnModification_Click(object sender, EventArgs e)
        {


            viderChamps();
        }

        private void frmModifierDetruireEtudiant_Load(object sender, EventArgs e)
        {
         
            remplirCombobox();
        }

        private void remplirCombobox()
        {
       
                ManagerEtudiant managerEtudiant = new ManagerEtudiant();

                BindingSource bindingsourceEtudiant = new BindingSource();

                using (SqlDataReader readerEtudiant = managerEtudiant.listerLesEtudiants())
                {
                    bindingsourceEtudiant.DataSource = readerEtudiant;
                    cmbRecherche.ValueMember = "no_etudiant, nom ,prenom";
                    cmbRecherche.DisplayMember = "noms"; // ce qui est affiché
                    cmbRecherche.DataSource = bindingsourceEtudiant;
                }
            

        }
    }
}
