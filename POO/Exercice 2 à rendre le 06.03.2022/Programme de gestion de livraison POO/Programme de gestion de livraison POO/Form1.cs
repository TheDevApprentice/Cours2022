using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programme_de_gestion_de_livraison_POO
{
    public partial class Form1 : Form
    {
        int id;
        entreeCamionneur entreeCamionneur = new entreeCamionneur();
        entreeCamion entreeCamion = new entreeCamion();
        entreeLivraison entreeLivraison = new entreeLivraison();
        EntreeVoyage EntreeVoyage = new EntreeVoyage();

        Voyage voyage;
        Camion camion;
        Voyage voyageSelectionnée;
        livraison livraisonSelectionnéDansLivraisonIncluse;
        livraison livraisonSelectionnéDansLivraisonNonAssignee;

        List<livraison> listeLivraisonNonAssignees = new List<livraison>();
        List<Voyage> listeVoyages = new List<Voyage>();
        List<Camionneur> listeCamionneurs = new List<Camionneur>();
        List<Camion> listeCamions = new List<Camion>();

        BindingSource bindingSource = new BindingSource();
        BindingSource bindingSource1 = new BindingSource();
        BindingSource bindingSource2 = new BindingSource();
        BindingSource bindingSource3 = new BindingSource();
        BindingSource bindingSource4 = new BindingSource();



        public entreeLivraison EntreeLivraison { get => entreeLivraison; set => entreeLivraison = value; }
        public entreeCamion EntreeCamion { get => entreeCamion; set => entreeCamion = value; }
        public entreeCamionneur EntreeCamionneur { get => entreeCamionneur; set => entreeCamionneur = value; }
        public EntreeVoyage EntreeVoyage1 { get => EntreeVoyage; set => EntreeVoyage = value; }
        internal Voyage Voyage { get => voyage; set => voyage = value; }
        internal Voyage VoyageSelectionnée { get => voyageSelectionnée; set => voyageSelectionnée = value; }

        internal List<livraison> ListeLivraisonNonAssignees { get => EntreeLivraison.ListeLivraisonNonAssignees; set => listeLivraisonNonAssignees = value; }
        internal List<Camionneur> ListeCamionneurs1 { get => EntreeCamionneur.ListeCamionneur; set => listeCamionneurs = value; }
        internal List<Voyage> ListeVoyages1 { get => EntreeVoyage.ListeVoyage; set => listeVoyages = value; }
        internal List<Camion> ListeCamions { get => EntreeCamion.ListeCamion; set => listeCamions = value; }
        internal Camion Camion { get => camion; set => camion = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bindingSource4.DataSource = ListeVoyages1;
            lst_voyages.DataSource = bindingSource4;

            lst_livraisonIncluses.DataSource = bindingSource3;

            bindingSource2.DataSource = ListeLivraisonNonAssignees;
            lst_livraisonNonAssignees.DataSource = bindingSource2;

            bindingSource1.DataSource = ListeCamions;
            cmb_camions.DataSource = bindingSource1;

            bindingSource.DataSource = ListeCamionneurs1;
            cmb_camionneurs.DataSource = bindingSource;

            // remmettre des binding sources pour les listes et les lst livraison assignées et non assignées
            ListeVoyages1.Add(new Voyage(id++, "Carrefour"));
            ListeVoyages1.Add(new Voyage(id++, "Montmartre"));
            ListeVoyages1.Add(new Voyage(id++, "Beauceville"));
            ListeVoyages1.Add(new Voyage(id++, "Paradise"));

            ListeLivraisonNonAssignees.Add(new livraison(300, 1000));
            ListeLivraisonNonAssignees.Add(new livraison(300, 2000));
            ListeLivraisonNonAssignees.Add(new livraison(500, 8000));
            ListeLivraisonNonAssignees.Add(new livraison(500, 2000));
            ListeLivraisonNonAssignees.Add(new livraison(500, 9000));
            ListeLivraisonNonAssignees.Add(new livraison(800, 2000));
            ListeLivraisonNonAssignees.Add(new livraison(900, 1000));
            ListeLivraisonNonAssignees.Add(new livraison(900, 2000));

            ListeCamionneurs1.Add(new Camionneur("Hugo", "Abric"));
            ListeCamionneurs1.Add(new Camionneur("Matieu", "Colin"));
            ListeCamionneurs1.Add(new Camionneur("Salah", "Kerioudj"));
            ListeCamionneurs1.Add(new Camionneur("Colin", "Farrel"));

            //ListeCamions.Add(new Camion());
            ListeCamions.Add(new Camion());
            ListeCamions.Add(new Camion(8000, 500));
            ListeCamions.Add(new Camion(1000, 300));
            ListeCamions.Add(new Camion(5000, 300));
            ListeCamions.Add(new Camion(2000, 800));


            bindingSource4.ResetBindings(false);
            bindingSource2.ResetBindings(false);
            bindingSource1.ResetBindings(false);
            bindingSource.ResetBindings(false);
        }

        private void btn_assigneLivraison_Click(object sender, EventArgs e)
        {
            int poidTotal = 0;
            int volumeTotal = 0;

            foreach (livraison livraisons in VoyageSelectionnée.Livraisons)
            {
                poidTotal += livraisons.Poids;
                volumeTotal += livraisons.Volume;
            }

            if (VoyageSelectionnée.Camion != null)
            {
                livraisonSelectionnéDansLivraisonNonAssignee = (livraison)lst_livraisonNonAssignees.SelectedItem;
                VérificationPoidsVolume(livraisonSelectionnéDansLivraisonNonAssignee, VoyageSelectionnée, ListeLivraisonNonAssignees, poidTotal, volumeTotal);

            }
            else
            {
                MessageBox.Show("Pas de camion choisi");
            }
                
                
          
           

            bindingSource3.ResetBindings(false);
            bindingSource2.ResetBindings(false);
        }
        private void btn_directionNonAssignees_Click(object sender, EventArgs e)
        {

            livraisonSelectionnéDansLivraisonIncluse = (livraison)lst_livraisonIncluses.SelectedItem;
            if (livraisonSelectionnéDansLivraisonIncluse != null)
            {

                VoyageSelectionnée.Livraisons.Remove(livraisonSelectionnéDansLivraisonIncluse);
                ListeLivraisonNonAssignees.Add(livraisonSelectionnéDansLivraisonIncluse);



            }
            else
            {
                MessageBox.Show("Aucun voyage selectionnée. veuillez essayer à nouveau");
            }

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
        private void ajouterVoyageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntreeVoyage1.ShowDialog();
            bindingSource4.ResetBindings(false);
        }
        private void lst_voyages_SelectedIndexChanged(object sender, EventArgs e)
        {
            grp_voyageSelectionne.Visible = true;
            btn_directionLivraisonsNonAssignees.Visible = true;
            btn_directionsLivraisonIncluses.Visible = true;

            VoyageSelectionnée = ListeVoyages1[lst_voyages.SelectedIndex];

            try
            {
                dtp_date.Value = VoyageSelectionnée.Date;
                cmb_camionneurs.Text = VoyageSelectionnée.Camionneur;

                if (VoyageSelectionnée.Camion != null)
                {
                    cmb_camions.Text = VoyageSelectionnée.Camion.ToString();
                }

                txt_distance.Text = VoyageSelectionnée.Distance.ToString();


                foreach (livraison livraisons in VoyageSelectionnée.Livraisons)
                {
                    lst_livraisonIncluses.Items.Add(livraisons);

                }
            }
            catch (Exception)
            {
                // contrôle d'une exception qui ne devrait pas exister

            }
            bindingSource3.DataSource = VoyageSelectionnée.Livraisons;
            bindingSource3.ResetBindings(true);
        }


        private void cmb_camionneurs_TextChanged(object sender, EventArgs e)
        {
            VoyageSelectionnée.Camionneur = cmb_camionneurs.Text;
        }


        private void cmb_camions_TextChanged(object sender, EventArgs e)
        {
            VoyageSelectionnée.Camion = (Camion)cmb_camions.SelectedItem;
        }

        private void txt_distance_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int result;

                bool success = int.TryParse(txt_distance.Text, out result);

                if (success == true && VoyageSelectionnée.Distance >= 0)
                {
                    VoyageSelectionnée.Distance = result;
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

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_date.Value.Day >= DateTime.Now.Day)
            {

                VoyageSelectionnée.Date = dtp_date.Value;
            }
            else
            {
                MessageBox.Show("Une date antérieure à aujourd'hui n'est pas valide");
            }

        }


        private void VérificationPoidsVolume(livraison LivraisonSelectionéeATransferer, Voyage VoyageSelectionnée, List<livraison> ListeLivraison, int poidTotalLivraisonnIncluse, int volumeTotalLivraisonIncluse)
        {
            int poidTotalAvecLaLivraisonAInclure = LivraisonSelectionéeATransferer.Poids + poidTotalLivraisonnIncluse;
            int volumeTotalAvecLivraisonAInclure = LivraisonSelectionéeATransferer.Volume + volumeTotalLivraisonIncluse;

            if (poidTotalAvecLaLivraisonAInclure > VoyageSelectionnée.Camion.Poids && volumeTotalAvecLivraisonAInclure > VoyageSelectionnée.Camion.Volume)
            {
                MessageBox.Show("la livraison totale sera trop grosse pour le camion");
            }

            if (lst_voyages.SelectedItem != null)
            {
                if (LivraisonSelectionéeATransferer.Poids > VoyageSelectionnée.Camion.Poids)
                {
                    MessageBox.Show("Le poid de ce camion est trop petit pour la livraison");

                }
                else if (LivraisonSelectionéeATransferer.Poids <= VoyageSelectionnée.Camion.Poids)
                {
                    if (LivraisonSelectionéeATransferer.Volume <= VoyageSelectionnée.Camion.Volume)
                    {
                        VoyageSelectionnée.Livraisons.Add(LivraisonSelectionéeATransferer);
                        ListeLivraison.Remove(LivraisonSelectionéeATransferer);
                    }
                    else if (LivraisonSelectionéeATransferer.Volume > VoyageSelectionnée.Camion.Volume)
                    {
                        MessageBox.Show("Le volume de cette livraison est supérieur au camion choisi");
                    }

                }
            }
            else
            {
                MessageBox.Show("Aucun voyage selectionnée. veuillez essayer à nouveau");
            }
        }

        private void cmb_camions_Click(object sender, EventArgs e)
        {
            
        } 
    }


}
