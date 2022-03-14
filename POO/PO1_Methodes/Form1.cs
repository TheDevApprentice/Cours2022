using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO1_Methodes
{
    public partial class Form1 : Form
    {
        List<Voiture> voituresDeCourse = new List<Voiture>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Voiture voiture1 = new Voiture(40, 40, new Point(10,40),0.1f, 10);
            voiture1.Couleur = Color.Red;
            Voiture voiture2 = new Voiture(40, 40, new Point(10, 150),5,40);
            Voiture voiture3 = new Voiture(40, 40, new Point(10, 260),2,20);
            voiture3.Couleur = Color.Blue;
            voituresDeCourse.Add(voiture1);
            voituresDeCourse.Add(voiture2);
            voituresDeCourse.Add(voiture3);
        }

        private void pictureBox_course_Paint(object sender, PaintEventArgs e)
        {
            foreach (Voiture voitureEnTraitement in voituresDeCourse)
            {
                Bitmap imageVoiture = voitureEnTraitement.Dessine();

                e.Graphics.DrawImage(imageVoiture, voitureEnTraitement.PositionX, voitureEnTraitement.PositionY);
            }
            
        }

        private void button_avancer_Click(object sender, EventArgs e)
        {
            foreach (Voiture voitureEnTraitement in voituresDeCourse)
            {
                float kmDeDeplacement = voitureEnTraitement.Avancer(5);
            }
            
            pictureBox_course.Invalidate();

            /*
            CompteInvestisseur compte = new CompteInvestisseur(500);
            CompteInvestisseur.ResultatOperation resultatDuRetrait = compte.RetirerFonds(500);

            switch (resultatDuRetrait)
            {
                case CompteInvestisseur.ResultatOperation.OK:
                    MessageBox.Show("Retrait effectué avec succès");
                    break;
                case CompteInvestisseur.ResultatOperation.FondInsuffisant:
                    MessageBox.Show("Fonds insuffisant");
                    break;
                case CompteInvestisseur.ResultatOperation.RetraitTropVolumineux:
                    MessageBox.Show("Parler avec notre gestionnaire");
                    break;
                default:
                    break;
            }
            */
        }
    }
}
