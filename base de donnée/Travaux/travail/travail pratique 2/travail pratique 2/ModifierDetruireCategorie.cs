using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace travail_pratique_2
{
    public partial class ModifierDetruireCategorie : Form
    {

        ManagerCours managerCours = new ManagerCours();
        BindingSource bindingsourceAfficheCategorie = new BindingSource();
        internal ManagerCours ManagerCours { get => managerCours; set => managerCours = value; }


        public ModifierDetruireCategorie()
        {
            InitializeComponent();
        }
        private void ModifierDetruireCategorie_Load(object sender, EventArgs e)
        {
            AfficherLesCategories();

            txt_ModifierCategorie.Text = "";
            cmb_RechercheCategorie.Text = "";


        }

        private void btn_Detruire_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_ModifierCategorie.Text != "")
                {
                    ManagerCours.detruireCategorie(int.Parse(cmb_RechercheCategorie.SelectedValue.ToString()));
                    MessageBox.Show("La catégorie a bien été détruit avec succès");
                }
                else
                {
                    cmb_RechercheCategorie.Text = "";
                    txt_ModifierCategorie.Clear();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("La catégorie n'a pas bien été détruit");
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ModifierCategorie.Text != "")
                {
                    ManagerCours.modifierCategorie(int.Parse(cmb_RechercheCategorie.SelectedValue.ToString()), txt_ModifierCategorie.Text);
                    MessageBox.Show("La catégorie a bien été modifié avec succès");
                }
                else
                {
                    cmb_RechercheCategorie.SelectedValue = "";
                    txt_ModifierCategorie.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("la catégorie n'a pas bien été modifié");
                MessageBox.Show(ex.Message);
            }


        }
        private void AfficherLesCategories()
        {
            using (SqlDataReader readerDeCategorie = ManagerCours.afficherLesCategories())
            {
                bindingsourceAfficheCategorie.DataSource = readerDeCategorie;
                cmb_RechercheCategorie.ValueMember = "no_categorie";
                cmb_RechercheCategorie.DisplayMember = "categorie";
                cmb_RechercheCategorie.DataSource = bindingsourceAfficheCategorie;
            }
        }
        private void cmb_RechercheCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ModifierCategorie.Text = cmb_RechercheCategorie.Text.Trim(' ');
        }
    }
}
