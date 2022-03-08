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

        internal List<Voiture> VoituresDeCourse { get => voituresDeCourse; set => voituresDeCourse = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Voiture voiture =  new Voiture(40, 0, 0, 0, 2, 10, Color.Red);
            VoituresDeCourse.Add(voiture);
            voiture = new Voiture(40, 0, 0, 100, 2, 10, Color.Blue);
            VoituresDeCourse.Add(voiture); 
               
            //VoituresDeCourse.Add(new Voiture(40, 0, 0, 200, 2, 10, Color.Yellow));
        }

        private void pictureBox_course_Paint(object sender, PaintEventArgs e)
        {
            foreach (Voiture voiture in VoituresDeCourse)
            {
                Bitmap bitmapDeLaVoiture = voiture.Dessiner();
                e.Graphics.DrawImage(bitmapDeLaVoiture, voiture.PositionX, voiture.PositionY); 

            }
            
        }

        private void button_avancer_Click(object sender, EventArgs e)
        {

            foreach (Voiture voiture in VoituresDeCourse)
            {
                voiture.Bouger(5); 
            }

            pictureBox_course.Invalidate(); 
        }
    }
}
