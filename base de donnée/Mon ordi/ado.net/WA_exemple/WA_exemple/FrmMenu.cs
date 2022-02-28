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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ajouterUnÉtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjouterEtudiant maForme = new frmAjouterEtudiant();
            maForme.ShowDialog();
        }

        private void modifierOuDétruireUnÉtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifierDetruireEtudiant maForme = new frmModifierDetruireEtudiant();
            maForme.ShowDialog();
        }
    }
}
