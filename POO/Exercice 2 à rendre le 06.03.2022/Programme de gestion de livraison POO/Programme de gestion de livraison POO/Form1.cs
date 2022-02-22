using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programme_de_gestion_de_livraison_POO
{
    public partial class Form1 : Form
    {
        entreeCamionneur entreeCamionneur = new entreeCamionneur();
        entreeCamion entreeCamion = new entreeCamion();
        entreeLivraison entreeLivraison = new entreeLivraison();

        Voyage voyage;
        Voyage newVoyage;

        List<Voyage> listeVoyages = new List<Voyage>();
        List<Camionneur> listeCamionneurs = new List<Camionneur>();
        List<Camion> listeCamions = new List<Camion>();

        BindingSource bindingSource = new BindingSource();
        BindingSource bindingSource1 = new BindingSource();
        BindingSource bindingSource2 = new BindingSource();
        BindingSource bindingSource3 = new BindingSource();
        BindingSource bindingSource4 = new BindingSource();
        BindingSource bindingSource5 = new BindingSource();
        BindingSource bindingSource6 = new BindingSource();

        internal List<Camionneur> ListeCamionneurs1 { get => EntreeCamionneur.ListeCamionneur; set => listeCamionneurs = value; }
       internal List<Voyage> ListeVoyages1 { get => listeVoyages; set => listeVoyages = value; }
        internal List<Camion> ListeCamions { get => EntreeCamion.ListeCamion; set => listeCamions = value; }
        internal Voyage Voyage { get => voyage; set => voyage = value; }
        public entreeLivraison EntreeLivraison { get => entreeLivraison; set => entreeLivraison = value; }
        public entreeCamion EntreeCamion { get => entreeCamion; set => entreeCamion = value; }
        public entreeCamionneur EntreeCamionneur { get => entreeCamionneur; set => entreeCamionneur = value; }
      
        internal Voyage VoyageSelectionnée { get => voyageSelectionnée; set => voyageSelectionnée = value; }
        internal Voyage NewVoyage { get => newVoyage; set => newVoyage = value; }

        Voyage voyageSelectionnée;


        //livraison livraison;

        int id;
        public int Id { get => id; set => id = value; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource4.DataSource = ListeVoyages1;
            lst_voyages.DataSource = bindingSource4;


            bindingSource3.DataSource = ListeLivraisonNonAssignees1;
            lst_livraisonNonAssignees.DataSource = bindingSource3;

            bindingSource2.DataSource = ListeLivraison;
            lst_livraisonIncluses.DataSource = bindingSource2;

            bindingSource1.DataSource = ListeCamions;
            cmb_camions.DataSource = bindingSource1;

            bindingSource.DataSource = ListeCamionneurs1;
            cmb_camionneurs.DataSource = bindingSource;

            // remmettre des binding sources pour les listes et les lst livraison assignées et non assignées

            ListeCamionneurs1.Add(new Camionneur("Hugo", "Abric"));
            ListeCamionneurs1.Add(new Camionneur("Matieu", "Colin"));

            ListeCamions.Add(new Camion(8000, 500));
            ListeCamions.Add(new Camion(1000, 300));
            ListeCamions.Add(new Camion(2000, 800));

            bindingSource4.ResetBindings(false);
            bindingSource3.ResetBindings(false);
            bindingSource2.ResetBindings(false);
            bindingSource1.ResetBindings(false);
            bindingSource.ResetBindings(false);
        }

        private void btn_assigneLivraison_Click(object sender, EventArgs e)
        {

        }

        private void btn_directionNonAssignees_Click(object sender, EventArgs e)
        {

        }

        private void camionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntreeCamionneur.ShowDialog();
            bindingSource.ResetBindings(false);
        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntreeCamion.ShowDialog();
            bindingSource1.ResetBindings(false);
        }

        private void livraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntreeLivraison.ShowDialog();
            bindingSource2.ResetBindings(false);
        }

        private void lst_voyages_SelectedIndexChanged(object sender, EventArgs e)
        {
                grp_voyageSelectionne.Visible = true;
                VoyageSelectionnée = ListeVoyages1[lst_voyages.SelectedIndex];

                dtp_date.Value = VoyageSelectionnée.Date;
                cmb_camionneurs.Text = VoyageSelectionnée.Camionneur;
                cmb_camions.Text = VoyageSelectionnée.Camion;
                txt_distance.Text = VoyageSelectionnée.Distance.ToString();

                bindingSource4.ResetBindings(false);
        }

        private void ajouterVoyageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewVoyage = new Voyage(Id++);
            ListeVoyages1.Add(NewVoyage);

            bindingSource4.ResetBindings(false);
        }

        private void cmb_camionneurs_TextChanged(object sender, EventArgs e)
        {
            VoyageSelectionnée.Camionneur = cmb_camionneurs.Text;

        }

        private void cmb_camions_TextChanged(object sender, EventArgs e)
        {
            VoyageSelectionnée.Camion = cmb_camions.Text;
        }

        private void txt_distance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int result;

                bool success = int.TryParse(txt_distance.Text, out result);

                if (success)
                {
                    VoyageSelectionnée.Distance = result;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_date.Value.Day <= DateTime.Now.Day)
            {

                VoyageSelectionnée.Date = dtp_date.Value;
            }
            else
            {
                MessageBox.Show("Une date antérieure à aujourd'hui n'est pas valide");
            }
           
        }


    }
}
