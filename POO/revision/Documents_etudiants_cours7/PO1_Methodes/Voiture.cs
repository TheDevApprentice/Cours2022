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

        public Voiture(float quantiteEssenceLitre, float capaciteResevoirEssenceLitre, float positionX, float positionY, float consommationEssence, float puissanceMoteur, Color couleur)
        {
            this.QuantiteEssenceLitre = quantiteEssenceLitre;
            this.CapaciteResevoirEssenceLitre = capaciteResevoirEssenceLitre;
            this.PositionX = positionX;
            this.PositionY = positionY;
            this.ConsommationEssence = consommationEssence;
            this.PuissanceMoteur = puissanceMoteur;
            this.Couleur = couleur;
        }

        public float QuantiteEssenceLitre { get => quantiteEssenceLitre; set => quantiteEssenceLitre = value; }
        public float CapaciteResevoirEssenceLitre { get => capaciteResevoirEssenceLitre; set => capaciteResevoirEssenceLitre = value; }

   

        public float PositionX { get => positionX; private set => positionX = value; }
        public float PositionY { get => positionY; set => positionY = value; }
        public float ConsommationEssence { get => consommationEssence; set => consommationEssence = value; }
        public float PuissanceMoteur { get => puissanceMoteur; set => puissanceMoteur = value; }
        public Color Couleur { get => couleur; set => couleur = value; }

       public float Bouger(float nombreDeSecondes)
        {
            float kmParcourus = 0;

            if (quantiteEssenceLitre > nombreDeSecondes * consommationEssence)
            {
                // assez d'essence 
                kmParcourus = nombreDeSecondes * puissanceMoteur;
                quantiteEssenceLitre = quantiteEssenceLitre - (nombreDeSecondes * consommationEssence);
                

            }
            else
            {
                // manque d'essence

                float tempsPossibleAvecEssenceDisponible = quantiteEssenceLitre / consommationEssence;
                kmParcourus = tempsPossibleAvecEssenceDisponible * puissanceMoteur;
                quantiteEssenceLitre = 0;

                
            }

            positionX += kmParcourus;
            return kmParcourus; 
        }

        public Bitmap Dessiner()
        {
            Bitmap bitmapVoiture = new Bitmap(200,200);

            using (Graphics graphic = Graphics.FromImage(bitmapVoiture))
            {
                Rectangle carosserie = new Rectangle(60,100,80,50);
                Rectangle roueArrierre = new Rectangle(25, 150, 25, 25);
                Rectangle roueAvant = new Rectangle(140, 150, 25, 25);
                Brush brushCarroserie = new SolidBrush(Couleur);
                Brush brushRoues = Brushes.Black;

                graphic.FillRectangle(brushCarroserie, carosserie);
                graphic.FillEllipse(brushRoues, roueArrierre);
                graphic.FillEllipse(brushRoues, roueAvant);
            }


            return bitmapVoiture; 
        }
        

    }
}
