using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace logiciel_de_gestion_de_panne
{
    public partial class Form1 : Form
    {
        List<Panne> Listepannes = new List<Panne>();
        BindingSource bindingSource = new BindingSource();

        int clients;
        Panne pannes;
        Panne panneSelectionnée;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = Listepannes;
            lst_pannes.DataSource = bindingSource;
        }

        private void btn_progresserEtat_Click(object sender, EventArgs e)
        {
            panneSelectionnée = (Panne)lst_pannes.SelectedItem;
            panneSelectionnée.Etat++;
       
        
            
            if(panneSelectionnée.Etat == EtatPanne.ternimné)
            {
                Listepannes.Remove(panneSelectionnée);
                
            }
            bindingSource.ResetBindings(false);
        }

        private void btn_dupliquer_Click(object sender, EventArgs e)
        {
            panneSelectionnée = (Panne)lst_pannes.SelectedItem;
            Panne copiePanne = new Panne(panneSelectionnée);
            
            Listepannes.Add(copiePanne);
            bindingSource.ResetBindings(false);
        }

        public void btn_ajouterPanne_Click(object sender, EventArgs e)
        {
            int nombredeclienttouchee;
            bool parseSuccesNbCLientTouche = int.TryParse(txtbox_nbClientsTouche.Text, out nombredeclienttouchee);
            if (parseSuccesNbCLientTouche)
            {
                clients = int.Parse(txtbox_nbClientsTouche.Text);

                pannes = new Panne(clients);

                Listepannes.Add(pannes);

                bindingSource.ResetBindings(false);
            }
          
   
           

        }

      
    }
}
