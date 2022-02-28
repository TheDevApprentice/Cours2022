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
    public partial class frmAjouterEtudiant : Form
    {
        public frmAjouterEtudiant()
        {
            InitializeComponent();
        }
        private Boolean champsRemplis()
        {

            if (txtNom.Text != "" && txtPrenom.Text != "" &&
                 txtCellulaire.Text != "" && cmbProvenance.SelectedValue != null)
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

                    managerEtudiant.ajouterEtudiant(txtPrenom.Text, txtNom.Text, txtCellulaire.Text, Convert.ToInt32(NUDHumour.Value), Convert.ToInt32(cmbProvenance.SelectedValue));

                    MessageBox.Show("tout 'est bien passé");
                }
                else
                {
                    MessageBox.Show("tout 'est pas bien passé");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          }

        private void frmAjouterEtudiant_Load(object sender, EventArgs e)
        {
            remplirCombobox();
           
  
        }

        private void remplirCombobox()
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
    }
}
