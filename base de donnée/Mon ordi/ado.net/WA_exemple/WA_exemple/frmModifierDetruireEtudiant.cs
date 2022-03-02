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
            try
            {
                if (true)
                {
                    ManagerEtudiant managerEtudiant = new ManagerEtudiant();
                  
                    managerEtudiant.updateEtudiant(2,txtPrenom.Text, txtNom.Text, txtCellulaire.Text, Convert.ToInt32(NUDHumour.Value), Convert.ToInt32(cmbProvenance.SelectedValue));

                    MessageBox.Show("tout c'est bien passé");
                }
                else
                {
                    MessageBox.Show("tout ne s'est pas bien passé");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            viderChamps();
        }

        private void frmModifierDetruireEtudiant_Load(object sender, EventArgs e)
        {

            remplirChamps();
            
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
        private void remplirChamps()
        {
            remplirCombobox();
            remplirComboboxProvenance();
        }

        private void remplirComboboxProvenance()
        {

            try
            {
                ManagerEtudiant managerEtudiant = new ManagerEtudiant();

                BindingSource bindingsourceProvenance = new BindingSource();

                using (SqlDataReader readerdeProvenance = managerEtudiant.listeLespays())
                {
                    bindingsourceProvenance.DataSource = readerdeProvenance;
                    cmbProvenance.ValueMember = "no_provenance";
                    cmbProvenance.DisplayMember = "nom_provenance";
                    cmbProvenance.DataSource = bindingsourceProvenance;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cmbRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
