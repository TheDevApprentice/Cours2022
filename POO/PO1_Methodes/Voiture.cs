using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PO1_Methodes
{
    class Voiture
    {
        private float quantiteEssenceLitre;
        private float capaciteResevoirEssenceLitre;
        private float positionX;
        private float positionY;
        private float consommationEssence;
        private float puissanceMoteur;
        private Color couleur;

        public float QuantiteEssenceLitre { get => quantiteEssenceLitre; set => quantiteEssenceLitre = value; }
        public float CapaciteResevoirEssenceLitre { get => capaciteResevoirEssenceLitre; set => capaciteResevoirEssenceLitre = value; }
        public float PositionX { get => positionX; private set => positionX = value; }
        public float PositionY { get => positionY; set => positionY = value; }
        public float ConsommationEssence { get => consommationEssence; set => consommationEssence = value; }
        public float PuissanceMoteur { get => puissanceMoteur; set => puissanceMoteur = value; }
        public Color Couleur { get => couleur; set => couleur = value; }

        public Voiture(float quantiteEssenceLitre, float capaciteResevoirEssenceLitre)
        {
            QuantiteEssenceLitre = quantiteEssenceLitre;
            CapaciteResevoirEssenceLitre = capaciteResevoirEssenceLitre;
            PositionX = 0;
            PositionY = 0;
        }

        public Voiture (float quantiteEssenceLitre, float capaciteResevoirEssenceLitre, 
            Point position, float consommation, float puissanceMoteur)
        {
            QuantiteEssenceLitre = quantiteEssenceLitre;
            CapaciteResevoirEssenceLitre = capaciteResevoirEssenceLitre;
            PositionX = position.X;
            PositionY = position.Y;
            ConsommationEssence = consommation;
            PuissanceMoteur = puissanceMoteur;
            Couleur = Color.LightCoral;
        }

        

        public void AjouterEssence(float quantiteAAjouter)
        {
            QuantiteEssenceLitre += quantiteAAjouter;
        }

        public float Avancer(float kmAParcourir)
        {
            return Bouger(kmAParcourir);
        }

        private float Bouger(float kmAParcourir)
        {
            float kmParcourue = 0;
            if (1 * kmAParcourir * consommationEssence > QuantiteEssenceLitre)
            {
                kmParcourue= QuantiteEssenceLitre/ consommationEssence * puissanceMoteur;

                QuantiteEssenceLitre = 0;
            }
            else
            {
                QuantiteEssenceLitre -= 1 * kmAParcourir* consommationEssence;
                kmParcourue= kmAParcourir * puissanceMoteur;
            }
            PositionX +=  kmParcourue;
            return kmParcourue;
         
        }

        public float Reculer(float kmAParcourir)
        {
            return Bouger(-kmAParcourir);
        }

        public Bitmap Dessine()
        {
            Bitmap bm = new Bitmap(200, 200);
            using (Graphics gr = Graphics.FromImage(bm))
            {
               // Rectangle valise = new Rectangle(25, 125, 50, 25);
                Rectangle carrosserie = new Rectangle(60, 100, 80, 50);
               // Rectangle capot = new Rectangle(125, 125, 50, 25);
                Rectangle roueArriere = new Rectangle(35, 150, 25, 25);
                Rectangle roueAvant = new Rectangle(140, 150, 25, 25);

                Rectangle cadreIndicateurEssence = new Rectangle(5, 5, 25, 100);
                int pourcentageReservoir = (int)(QuantiteEssenceLitre / CapaciteResevoirEssenceLitre * 100);
                Rectangle indicateurEssence = new Rectangle(5, 5+(100- pourcentageReservoir), 25, pourcentageReservoir);
                Brush brushCarosserie = new SolidBrush(Couleur);
               // gr.FillRectangle(brushCarosserie, valise);
                gr.FillRectangle(brushCarosserie, carrosserie);
               // gr.FillRectangle(brushCarosserie, capot);
                gr.FillEllipse(Brushes.Blue, roueArriere);
                gr.FillEllipse(Brushes.Blue, roueAvant);
                gr.FillRectangle(Brushes.Green, indicateurEssence);
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    gr.DrawRectangle(pen, cadreIndicateurEssence);
                }   
            }
            return bm;
        }
    }
}
