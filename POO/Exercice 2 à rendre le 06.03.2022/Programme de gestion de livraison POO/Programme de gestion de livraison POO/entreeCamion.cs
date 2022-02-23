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
            Poids = int.Parse(txt_poids.Text);
            Volume = int.Parse(txt_volume.Text);

            NewCamion = new Camion(Poids, Volume);

            ListeCamion.Add(NewCamion);

            txt_poids.Clear();
            txt_volume.Clear();

            this.Close();
        }
    }
}
