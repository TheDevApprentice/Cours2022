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


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfficherLesEtudiants();
            AfficherLesHobbys();
            EffacerTextBox();


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
            
            if (cmb_etudiant.Text != "" && cmb_Hobby.Text != "")
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
    }
}
