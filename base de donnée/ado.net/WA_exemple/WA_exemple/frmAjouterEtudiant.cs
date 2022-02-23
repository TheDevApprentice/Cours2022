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
using System.Data;
namespace WA_exemple
{
    public partial class frmAjouterEtudiant : Form
    {
        public frmAjouterEtudiant()
        {
            InitializeComponent();
        }
        private Boolean champsRemplis()
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" &&
                 txtCellulaire.Text != "" && cmbProvenance.ToString() != "")
                return true;
            else
                return false;
        }
       
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (champsRemplis())
                {
                    ManagerEtudiant managerEtudiant = new ManagerEtudiant();

                    managerEtudiant.ajouterEtudiant(txtPrenom.Text, txtNom.Text, Convert.ToInt32(txtCellulaire.Text), cmbProvenance.Text); // remplacer cmb provenance par convert.toint32(cmbProvenance.selectedValue)
                    MessageBox.Show("ca a marché");
                }
                else
                {
                    MessageBox.Show("il faut remplir les champs");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void remplirCmb()
        {
            ManagerEtudiant managerEtudiant = new ManagerEtudiant();
            BindingSource bindingSourceProvenance = new BindingSource();
            
            using (SqlDataReader readerProvenance = managerEtudiant.listeLespays())
            {
                bindingSourceProvenance.DataSource = readerProvenance;
                cmbProvenance.ValueMember = " "; // on cherche le numéro de provenance qui doit être marqué comme c'est écrit dans la base de donnée
                cmbProvenance.DisplayMember = "provenance"; // ce qui est affiché
                cmbProvenance.DataSource = bindingSourceProvenance;
            }  

        }
        private void frmAjouterEtudiant_Load(object sender, EventArgs e)
        {
            remplirCmb();
        }
    }
}
