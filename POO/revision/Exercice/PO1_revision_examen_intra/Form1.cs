using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO1_revision_examen_intra
{
    public partial class FormPrincipale : Form
    {
        Commande commande;
        List<Commande> listeCommande = new List<Commande>();

        BindingSource bindingSource = new BindingSource(); 

        internal Commande Commande { get => commande; set => commande = value; }
        internal List<Commande> ListeCommande { get => listeCommande; set => listeCommande = value; }

        public FormPrincipale()
        {
            InitializeComponent();
        }
        
        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = listeCommande;
            listBox_commandes.DataSource = bindingSource; 

        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (textBox_descriptionAjouterCommande.Text != " " && textBox_prixAjouterCommnande.Text != " ")
            {
                ListeCommande.Add(new Commande(int.Parse(textBox_prixAjouterCommnande.Text), textBox_descriptionAjouterCommande.Text));
                bindingSource.ResetBindings(false); 
            }
        }

        private void button_marquerCompletee_Click(object sender, EventArgs e)
        {
            ListeCommande[listBox_commandes.SelectedIndex].Etat = true;
            bindingSource.ResetBindings(false);
        }

       
    }
}
