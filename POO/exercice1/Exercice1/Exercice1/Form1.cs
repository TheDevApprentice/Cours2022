using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice1
{
    public partial class Form1 : Form
    {
        List<string> listeDeNom = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            string nomAAjouter = txt_Aajouter.Text;
            listeDeNom.Add(nomAAjouter);
            txt_Aajouter.Text = " ";
            MessageBox.Show("ajouter avec succés"); 
            

        }

        private void btn_retirer_Click(object sender, EventArgs e)
        {
            //problème qui peuvent arriver : 

            //imput usager invalid car pas un int
            //input usager out of range
            string entreeUsager = txt_Aretirer.Text;
            int indexARetirer;
            bool parseAvecSuccès = int.TryParse(entreeUsager, out indexARetirer);

            
            if (parseAvecSuccès)
            {
                if (indexARetirer < listeDeNom.Count)
                {
                    listeDeNom.RemoveAt(indexARetirer);
                    MessageBox.Show("retirer avec succès");
                }
                else if (indexARetirer < 0)
                {
                    MessageBox.Show("L'index doit être supérieur à 0"); 
                }
                else
                {
                    MessageBox.Show(": index est trop grtand pour la liste"); 
                }

               
            }
            else
            {
                MessageBox.Show("entrée invalide");
            }

            
           


        }

        private void btn_debug_Click(object sender, EventArgs e)
        {
            foreach (string nomCourant in listeDeNom)
            {
                System.Diagnostics.Debug.WriteLine(nomCourant); 
            }
        }
    }
}
