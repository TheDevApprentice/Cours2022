using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace exercice_sur_les_relation_nM
{
    public partial class Form1 : Form
    {
        BindingSource bindingSourceEtudiants = new BindingSource();
        BindingSource bindingSourceHobbys = new BindingSource();
        ManagerEtudiant managerEtudiant = new ManagerEtudiant();
        BindingSource bindingDataGrid = new BindingSource(); 


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            AfficherLesEtudiants();
            AfficherLesHobbys();
            EffacerTextBox();
         
                dgv_hobbyEtudiant.Rows.Clear();


            

        }
        private void EffacerTextBox()
        {

            cmb_etudiant.Text = "";
            cmb_Hobby.Text = "";

        }
        private void AfficherLesEtudiants()
        {
            try
            {
                using (SqlDataReader readerEtudiants = managerEtudiant.AfficherLesEtudiants())
                {
                    bindingSourceEtudiants.DataSource = readerEtudiants;
                    cmb_etudiant.ValueMember = "no_etudiant";
                    cmb_etudiant.DisplayMember = "noms";
                    cmb_etudiant.DataSource = bindingSourceEtudiants;

                    //cmb_etudiant.DropDownStyle = ComboBoxStyle.DropDownList;

                    //cmb_etudiant.AutoCompleteMode = AutoCompleteMode.Suggest;
                    //cmb_etudiant.AutoCompleteSource = AutoCompleteSource.ListItems;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void AfficherLesHobbys()
        {
            try
            {
                using (SqlDataReader readerDeHobbys = managerEtudiant.AfficherLesHobbys())
                {
                    bindingSourceHobbys.DataSource = readerDeHobbys;
                    cmb_Hobby.ValueMember = "no_hobby";
                    cmb_Hobby.DisplayMember = "nom_hobby";
                    cmb_Hobby.DataSource = bindingSourceHobbys;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_associerEtudiantHobby_Click(object sender, EventArgs e)
        {

            if (cmb_etudiant.SelectedValue != null)
            {
                int no_etudiant = int.Parse(cmb_etudiant.SelectedValue.ToString());
                int no_hobby = int.Parse(cmb_Hobby.SelectedValue.ToString());

                try
                {
                    managerEtudiant.AssocierEtudiantHobby(no_etudiant, no_hobby);
                }
                catch (SqlException sqlLex)
                {

                    MessageBox.Show(sqlLex.Message);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }

            }
            else
            {
                MessageBox.Show("Vous devez choisir une valeur dans les deux listes");
                EffacerTextBox();

            }
        }

        private void nombreDeHobbyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            {
                NombreDehobby nombreDehobby = new NombreDehobby();

                nombreDehobby.ShowDialog();
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {

            if (txt_hobby.Text != "")
            {
                int no_etudiant = int.Parse(cmb_etudiant.SelectedValue.ToString());

                string hobby;

                try
                {
                    hobby = txt_hobby.Text;

                    int no_hobby = managerEtudiant.ajouterNouveauHobbyEtAssocier(hobby);
                    managerEtudiant.AssocierEtudiantHobby(no_etudiant, no_hobby);

                    MessageBox.Show("Le hobby a bien été lier à l'étudiant sélectionné ");
                }
                catch (SqlException Sqlex)
                {
                    if (Sqlex.Number == 2601)
                    {
                        MessageBox.Show("ce hobby existe déjà");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
      
        }

        private void btn_ajouterHobbyEtAssocier_Click(object sender, EventArgs e)
        {
            if (cmb_etudiant.Text != "" || cmb_etudiant.SelectedValue != null)
            {
                grp_ajouterEtAssocierHobby.Visible = true;
            }

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            EffacerTextBox();
            grp_ajouterEtAssocierHobby.Visible = false;
        }

        private void cmb_etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmb_etudiant_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cmb_etudiant_SelectionChangeCommitted(object sender, EventArgs e)
        {

            dgv_hobbyEtudiant.Rows.Clear();

            try
            {
                int no_etudiant;
                no_etudiant = int.Parse(cmb_etudiant.SelectedValue.ToString());


                using (SqlDataReader ReaderdataGridView = managerEtudiant.ListerHobbyEtudiant(no_etudiant))
                {
                    if (ReaderdataGridView.HasRows)
                    {
                        bindingDataGrid.DataSource = ReaderdataGridView;
                        dgv_hobbyEtudiant.DataSource = bindingDataGrid;
                        
                    }
                    else
                    {
                        dgv_hobbyEtudiant.Rows.Clear(); 
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
      
        }
    }
}
