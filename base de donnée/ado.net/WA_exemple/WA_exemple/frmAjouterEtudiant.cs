using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                    managerEtudiant.ajouterEtudiant(txtPrenom.Text, txtNom.Text, Convert.ToInt32(txtCellulaire.Text), cmbProvenance.Text);
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

        
    }
}
