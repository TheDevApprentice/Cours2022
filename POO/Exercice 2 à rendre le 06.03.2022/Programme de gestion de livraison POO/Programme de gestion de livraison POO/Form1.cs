using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programme_de_gestion_de_livraison_POO
{
    public partial class Form1 : Form
    {
        /* Initialisation des attributs*/

        int id;
        bool PoidsEtVolumeBonPourAssignation = true;

        /***/

        lbl_entreeCamionneurPrenom entreeCamionneur = new lbl_entreeCamionneurPrenom();
        entreeCamion entreeCamion = new entreeCamion();
        entreeLivraison entreeLivraison = new entreeLivraison();
        EntreeVoyage EntreeVoyage = new EntreeVoyage();

        /*******/

        Voyage voyage;
        Camion camion;
        Voyage voyageSelectionnée;
        livraison livraisonSelectionnéDansLivraisonIncluse;
        livraison livraisonSelectionnéDansLivraisonNonAssignee;

        /*******/

        List<livraison> listeLivraisonNonAssignees = new List<livraison>();
        List<Voyage> listeVoyages = new List<Voyage>();
        List<Camionneur> listeCamionneurs = new List<Camionneur>();
        List<Camion> listeCamions = new List<Camion>();

        /*******/

        BindingSource bindingSource = new BindingSource();
        BindingSource bindingSource1 = new BindingSource();
        BindingSource bindingSource2 = new BindingSource();
        BindingSource bindingSource3 = new BindingSource();
        BindingSource bindingSource4 = new BindingSource();

        /**********************************************************/

        /* Encapsulation des attribut en utilisant leurs propriétés*/

        public entreeLivraison EntreeLivraison { get => entreeLivraison; set => entreeLivraison = value; }
        public entreeCamion EntreeCamion { get => entreeCamion; set => entreeCamion = value; }
        public lbl_entreeCamionneurPrenom EntreeCamionneur { get => entreeCamionneur; set => entreeCamionneur = value; }
        public EntreeVoyage EntreeVoyage1 { get => EntreeVoyage; set => EntreeVoyage = value; }

        /*******/

        internal Voyage Voyage { get => voyage; set => voyage = value; }
        internal Voyage VoyageSelectionnée { get => voyageSelectionnée; set => voyageSelectionnée = value; }
        internal Camion Camion { get => camion; set => camion = value; }

        /*******/

        internal List<livraison> ListeLivraisonNonAssignees { get => EntreeLivraison.ListeLivraisonNonAssignees; set => listeLivraisonNonAssignees = value; }
        internal List<Camionneur> ListeCamionneurs1 { get => EntreeCamionneur.ListeCamionneur; set => listeCamionneurs = value; }
        internal List<Voyage> ListeVoyages1 { get => EntreeVoyage.ListeVoyage; set => listeVoyages = value; }
        internal List<Camion> ListeCamions { get => EntreeCamion.ListeCamion; set => listeCamions = value; }

        /**********************************************************/

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


            ListeCamions.Add(new Camion(5000, 2000));
            ListeCamions.Add(new Camion(8000, 500));
            ListeCamions.Add(new Camion(1000, 300));
            ListeCamions.Add(new Camion(5000, 300));
            ListeCamions.Add(new Camion(2000, 800));

            bindingSource4.ResetBindings(true);
            bindingSource2.ResetBindings(true);
            bindingSource1.ResetBindings(true);
            bindingSource.ResetBindings(true);
        }
        private void btn_assigneLivraison_Click(object sender, EventArgs e) /*Bouton d'assignation de livraison à un voyage */
        {
            int poidTotal = 0;
            int volumeTotal = 0;

            if (VoyageSelectionnée.Camion != null)
            {
                verificationPoidsVolumeLivraison(ref poidTotal, ref volumeTotal);

                if (VoyageSelectionnée.Livraisons.Count != 0 && VoyageSelectionnée.Camion != null)
                {
                    foreach (Camion camion in ListeCamions) // faire en sorte que je puisse faire une exception sur le camion qui est déja dans la textbox
                    {
                        if (poidTotal > camion.Poids && volumeTotal > camion.Volume)
                        {
                            cmb_camions.Enabled = false;
                        }
                    }
                }
                if (VoyageSelectionnée.Camion != null)
                {
                    livraisonSelectionnéDansLivraisonNonAssignee = (livraison)lst_livraisonNonAssignees.SelectedItem;
                    VérificationPoidsVolumeCamion(livraisonSelectionnéDansLivraisonNonAssignee, VoyageSelectionnée, ListeLivraisonNonAssignees, poidTotal, volumeTotal);
                }
                else
                {
                    MessageBox.Show("Pas de camion choisi");
                }
            }
            else
            {
                cmb_camions.Enabled = true;
                MessageBox.Show("Impossible de lier une livraison si le camion n'est pas spécifié");
            }

            bindingSource3.ResetBindings(true);
            bindingSource2.ResetBindings(true);
            bindingSource1.ResetBindings(true);

        }
        private void btn_directionNonAssignees_Click(object sender, EventArgs e) /*Bouton pour enlever une livraison à un voyage */
        {
            int poidTotal = 0;
            int volumeTotal = 0;

            verificationPoidsVolumeLivraison(ref poidTotal, ref volumeTotal);

            if (VoyageSelectionnée.Livraisons.Count != 0)
            {
                foreach (Camion camion in ListeCamions)
                {
                    if (camion != ListeCamions[cmb_camions.SelectedIndex])
                    {
                        if (poidTotal <= camion.Poids || volumeTotal <= camion.Volume)
                        {
                            cmb_camions.Enabled = true;
                        }
                        if (poidTotal > camion.Poids || volumeTotal > camion.Volume)
                        {
                            cmb_camions.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                cmb_camions.Enabled = true;
            }

            livraisonSelectionnéDansLivraisonIncluse = (livraison)lst_livraisonIncluses.SelectedItem;

            if (livraisonSelectionnéDansLivraisonIncluse != null)
            {
                VoyageSelectionnée.Livraisons.Remove(livraisonSelectionnéDansLivraisonIncluse);
                ListeLivraisonNonAssignees.Add(livraisonSelectionnéDansLivraisonIncluse);
            }
            else
            {
                MessageBox.Show("Aucune livraison à déplacer");
            }

            bindingSource3.ResetBindings(true);
            bindingSource2.ResetBindings(true);
            bindingSource1.ResetBindings(true);
        }

        /* Bouton pour accès aux formulaires d'entrée   */

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

        /*************************************************/

        private void lst_voyages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListeVoyages1[lst_voyages.SelectedIndex] != null)
            {
                grp_voyageSelectionne.Visible = true;
                btn_directionLivraisonsNonAssignees.Visible = true;
                btn_directionsLivraisonIncluses.Visible = true;
            }
            remplissageTxtBox();
        }
        private void cmb_camionneurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            VoyageSelectionnée.Camionneur = cmb_camionneurs.Text;
        }
        private void cmb_camionneurs_Leave(object sender, EventArgs e)
        {
            cmb_camionneurs.Text = VoyageSelectionnée.Camionneur;
        }
        private void cmb_camions_TextChanged(object sender, EventArgs e)
        {

            if (cmb_camions.Text != "" && lst_livraisonIncluses.Items.Count == 0)
            {
                VoyageSelectionnée.Camion = (Camion)cmb_camions.SelectedItem;
            }
            if (VoyageSelectionnée.Camion == null)
            {
                cmb_camions.Enabled = true;
                cmb_camions.Text = "";
            }

        }
        private void cmb_camions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_livraisonIncluses.Items.Count != 0)
            {
                int poidTotal = 0;
                int volumeTotal = 0;

                verificationPoidsVolumeLivraison(ref poidTotal, ref volumeTotal);

                if (poidTotal > ListeCamions[cmb_camions.SelectedIndex].Poids && volumeTotal > ListeCamions[cmb_camions.SelectedIndex].Volume)
                {
                    PoidsEtVolumeBonPourAssignation = false;
                    MessageBox.Show("mauvais camion");
                    if (!PoidsEtVolumeBonPourAssignation)
                    {
                        cmb_camions.Text = VoyageSelectionnée.Camion.ToString();
                    }
                }
                else
                {
                    VoyageSelectionnée.Camion = (Camion)cmb_camions.SelectedItem;
                }

            }

        }
        private void cmb_camions_Leave(object sender, EventArgs e)
        {
            if (VoyageSelectionnée.Camion != null)
            {
                cmb_camions.Text = VoyageSelectionnée.Camion.ToString();
            }
        }
        private void txt_distance_Leave(object sender, EventArgs e)
        {
            if (txt_distance.Text == "0" || txt_distance.Text == "")
            {
                MessageBox.Show("La distance ne peut pas être à 0 ou null");
                txt_distance.Text = "0";
            }
        }
        private void txt_distance_TextChanged(object sender, EventArgs e)
        {
            int result;

            bool success = int.TryParse(txt_distance.Text, out result);
            if (success)
            {
                VoyageSelectionnée.Distance = result;
            }
            else
            {

                txt_distance.Clear();
            }

        }
        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtp_date.Value.Date >= VoyageSelectionnée.Date.Date)
                {
                    VoyageSelectionnée.Date = dtp_date.Value;
                }
                else
                {
                    dtp_date.Value = VoyageSelectionnée.Date.Date;
                    MessageBox.Show("Une date antérieure à aujourd'hui n'est pas valide");
                }
            }
            catch (Exception)
            {
                // ici j'empêche un bug qui fait que lorsque que je veux selectionné la date d'aujourd'hui, malgrès la validation, me retourne 
                // un message d'erreur comme quoi la date ne peux pas être celle d'aujourd'hui
            }


        }

        /* VérificationPoidsVolumeCamion */
        /*Fonction qui permet de calculer la livraison totale (poids/volume totale) qui est présente dans le voyage et qui vérifie que l'on peut mettre dans le voyage 
           * la livraison choisi dans les les livraison en attentes
           * d'assignation et qui gère cette assignation */
        private void VérificationPoidsVolumeCamion(livraison LivraisonSelectionéeATransferer, Voyage VoyageSelectionnée, List<livraison> ListeLivraison, int poidTotalLivraisonnIncluse, int volumeTotalLivraisonIncluse)
        {
            int poidTotalAvecLaLivraisonAInclure = LivraisonSelectionéeATransferer.Poids + poidTotalLivraisonnIncluse;
            int volumeTotalAvecLivraisonAInclure = LivraisonSelectionéeATransferer.Volume + volumeTotalLivraisonIncluse;

            if (volumeTotalAvecLivraisonAInclure <= VoyageSelectionnée.Camion.Volume && poidTotalAvecLaLivraisonAInclure <= VoyageSelectionnée.Camion.Poids)
            {
                if (LivraisonSelectionéeATransferer.Poids <= VoyageSelectionnée.Camion.Poids)
                {
                    if (LivraisonSelectionéeATransferer.Volume <= VoyageSelectionnée.Camion.Volume)
                    {
                        VoyageSelectionnée.Livraisons.Add(LivraisonSelectionéeATransferer);
                        ListeLivraison.Remove(LivraisonSelectionéeATransferer);
                    }
                    else
                    {
                        MessageBox.Show("Le volume de cette livraison est supérieur au camion choisi");
                    }
                }
                else if (LivraisonSelectionéeATransferer.Poids > VoyageSelectionnée.Camion.Poids)
                {
                    MessageBox.Show("Le poid de ce camion est trop petit pour la livraison");

                }
            }
            else if (LivraisonSelectionéeATransferer.Poids > VoyageSelectionnée.Camion.Poids)
            {
                MessageBox.Show("Le poid de ce camion est trop petit pour la livraison");

            }
            else
            {
                MessageBox.Show("La livraison total sera trop grosse pour le camion");

            }
        }
        private void remplissageTxtBox()
        {
            VoyageSelectionnée = ListeVoyages1[lst_voyages.SelectedIndex];

            int poidTotal = 0;
            int volumeTotal = 0;
            verificationPoidsVolumeLivraison(ref poidTotal, ref volumeTotal);


            try
            {
                dtp_date.Value = VoyageSelectionnée.Date.Date;
                cmb_camionneurs.Text = VoyageSelectionnée.Camionneur;

                if (VoyageSelectionnée.Camion != null)
                {
                    cmb_camions.Text = VoyageSelectionnée.Camion.ToString();

                    if (volumeTotal >= VoyageSelectionnée.Camion.Volume || poidTotal >= VoyageSelectionnée.Camion.Poids)
                    {
                        cmb_camions.Enabled = false;
                    }
                }
                if (VoyageSelectionnée.Camion == null)
                {
                    cmb_camions.Enabled = true;
                    cmb_camions.Text = "";
                }

              


                if (VoyageSelectionnée.Distance != 0)
                {

                    txt_distance.Text = VoyageSelectionnée.Distance.ToString();
                }
                else
                {
                    txt_distance.Text = "";
                }


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
        } /* Fonction pour remplir les TextBox lors d'un clic sur un voyage */
        private void verificationPoidsVolumeLivraison(ref int poidTotal, ref int volumeTotal)
        {
            foreach (livraison livraisons in VoyageSelectionnée.Livraisons)
            {
                volumeTotal += livraisons.Volume;
                poidTotal += livraisons.Poids;
            }

        } /* Fonction qui permet de calculer le poids total et le volume totale des livraisons dans un voyage */


    }
}