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
            cmbProvenance.SelectedValue = "";
        }
        private void btnModification_Click(object sender, EventArgs e)
        {

        }

        private void frmModifierDetruireEtudiant_Load(object sender, EventArgs e)
        {

        }
    }
}
