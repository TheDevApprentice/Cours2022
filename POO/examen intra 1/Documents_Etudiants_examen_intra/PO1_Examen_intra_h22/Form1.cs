using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO1_Examen_intra_h22
{
    public partial class Form1 : Form
    {
        Voiture voiture;
        List<Voiture> listeVoiture = new List<Voiture>();

        BindingSource bindingSource = new BindingSource();

        internal Voiture Voiture { get => voiture; set => voiture = value; }
        internal List<Voiture> ListeVoiture { get => listeVoiture; set => listeVoiture = value; }
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = ListeVoiture;
            listBox_voiture.DataSource = bindingSource;

            //ListeVoiture.Add(new Voiture("Toyota yarris"));
            //ListeVoiture.Add(new Voiture("Ferrari feroce"));

            bindingSource.ResetBindings(false);
        }

        private void button_ajouterKm_Click(object sender, EventArgs e)
        {
            int Kilométrage;
            bool sucess = int.TryParse(textBox_kmAAjouter.Text, out Kilométrage);
            try
            {
                if (sucess == true)
                {
                    ListeVoiture[listBox_voiture.SelectedIndex].KilometrageDeLaVoiture = Kilométrage;
                }
                else
                {
                    MessageBox.Show("Ceci n'est pas une valeur approprié");
                }
               

            }
            catch (Exception)
            {

                MessageBox.Show("Aucune Voiture n'est présente dans la liste");
            }
            bindingSource.ResetBindings(false);
        }

        private void button_changementDHuile_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListeVoiture.Count != 0)
                {
                    ListeVoiture[listBox_voiture.SelectedIndex].DateHeureChangementHuile = DateTime.Now;

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Aucune Voiture n'est présente dans la liste");
            }

            bindingSource.ResetBindings(false);
        }
    }
}
