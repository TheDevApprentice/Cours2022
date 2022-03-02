using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programme_de_gestion_de_livraison_POO
{
    public partial class entreeCamion : Form
    {

        Camion newCamion;
        List<Camion> ListeCamions = new List<Camion>();

        int poids;
        int volume;

        public int Poids { get => poids; set => poids = value; }
        public int Volume { get => volume; set => volume = value; }
        internal List<Camion> ListeCamion { get => ListeCamions; set => ListeCamions = value; }
        internal Camion NewCamion { get => newCamion; set => newCamion = value; }

        public entreeCamion()
        {
            InitializeComponent();
        }

        private void entreeCamion_Load(object sender, EventArgs e)
        {

        }

        private void btn_validateEntreeCamion_Click(object sender, EventArgs e)
        {
            try
            {
                int resultPoids;
                int resultVolume;

                bool successPoids = int.TryParse(txt_poids.Text, out resultPoids);
                bool successVolume = int.TryParse(txt_poids.Text, out resultVolume);

                if (successPoids == true && successVolume == true)
                {
                    Poids = resultPoids;
                    Volume = resultVolume;

                    NewCamion = new Camion(Volume, Poids);

                    ListeCamion.Add(NewCamion);

                    txt_poids.Clear();
                    txt_volume.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ceci n'est pas une valeur approprié.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        
        }
    }
}
