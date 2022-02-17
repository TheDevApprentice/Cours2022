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
        visualisationVoyage visualisation = new visualisationVoyage();
        Voyage voyage;
        Voyage voyageAvisualiser;

        List<livraison> listeLivraison = new List<livraison>();
        List<livraison> listeLivraisonNonAssignees = new List<livraison>();
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

        int id;
        internal List<Camionneur> ListeCamionneurs1 { get => EntreeCamionneur.ListeCamionneur; set => listeCamionneurs = value; }
        internal List<livraison> ListeLivraison { get => listeLivraison; set => listeLivraison = value; }
        internal List<livraison> ListeLivraisonNonAssignees1 { get => EntreeLivraison.ListeLivraisonNonAssignees; set => listeLivraisonNonAssignees = value; }
        internal List<Voyage> ListeVoyages1 { get => listeVoyages; set => listeVoyages = value; }
        internal List<Camion> ListeCamions { get => EntreeCamion.ListeCamion; set => listeCamions = value; }
        public int Id { get => id; set => Voyage.Id = value; }
        internal Voyage Voyage { get => voyage; set => voyage = value; }
        public entreeLivraison EntreeLivraison { get => entreeLivraison; set => entreeLivraison = value; }
        public entreeCamion EntreeCamion { get => entreeCamion; set => entreeCamion = value; }
        public entreeCamionneur EntreeCamionneur { get => entreeCamionneur; set => entreeCamionneur = value; }
        public visualisationVoyage Visualisation { get => visualisation; set => visualisation = value; }
        internal Voyage VoyageAvisualiser { get => voyageAvisualiser; set => voyageAvisualiser = value; }

        livraison livraison;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource4.DataSource = ListeVoyages1;
            lst_voyages.DataSource = bindingSource4;

            bindingSource3.DataSource = ListeLivraison;
            lst_livraisonIncluses.DataSource = bindingSource3;

            bindingSource2.DataSource = ListeLivraisonNonAssignees1;
            lst_livraisonNonAssignees.DataSource = bindingSource2;

            bindingSource1.DataSource = ListeCamions;
            cmb_camions.DataSource = bindingSource1;

            bindingSource.DataSource = ListeCamionneurs1;
            cmb_camionneurs.DataSource = bindingSource;


        }

        private void btn_assigneLivraison_Click(object sender, EventArgs e)
        {
            livraison livraisonAssigner = (livraison)lst_livraisonNonAssignees.SelectedItem;
            ListeLivraison.Add(livraisonAssigner);
            ListeLivraisonNonAssignees1.Remove(livraisonAssigner);

            bindingSource3.ResetBindings(false);
            bindingSource2.ResetBindings(false);
        }

        private void btn_directionNonAssignees_Click(object sender, EventArgs e)
        {
            livraison livraisonAssigner = (livraison)lst_livraisonIncluses.SelectedItem;
            ListeLivraisonNonAssignees1.Add(livraisonAssigner);
            ListeLivraison.Remove(livraisonAssigner);


            bindingSource3.ResetBindings(false);
            bindingSource2.ResetBindings(false);
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

        //private void gestionDesExceptions()
        //{
        //    try
        //    {

        //    }
        //    catch (Exception)
        //    {

        //        throw new Exception();
        //    }
        //}

        private void lst_voyages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visualisation.ShowDialog();
            VoyageAvisualiser = (Voyage)lst_voyages.SelectedItem;
        }

        private void ajouterVoyageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id++;
            DateTime date = dtp_date.Value;
            string camionneur = cmb_camionneurs.Text;
            string camion = cmb_camions.Text;
            float distance = int.Parse(txt_distance.Text);
            livraison = (livraison)lst_livraisonIncluses.SelectedItem;
            Voyage newVoyage = new Voyage(Id, date, camionneur, camion, distance, livraison);
            ListeVoyages1.Add(newVoyage);

            bindingSource4.ResetBindings(false);

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grp_voyageSelectionne.Visible = true;
        }


    }
}
