using System;
using System.Collections.Generic;
using System.Text;

namespace PO1_Methodes
{
    class CompteInvestisseur
    {
        const int LimiteADecouvert = 500;
        private int fondsDisponible;
        private int fraisDus;

        public CompteInvestisseur(int fondsInitiaux)
        {
            this.fondsDisponible = fondsInitiaux;
            fraisDus = 0;
        }

        public int FraisDus { get => fraisDus; set => fraisDus = value; }

        /*public void RetirerFonds(int fondsARetirer)
        {
            if(fondsARetirer > 10000)
            {
                throw new Exception("i am afraid i can't let you do that.");
            }
            if (fondsDisponible < fondsARetirer)
            {
                fraisDus++;// :)
            }
            if (fondsDisponible + LimiteADecouvert < fondsARetirer)
            {
                throw new Exception("Fonds insuffisants");
            }
            fondsDisponible -= fondsARetirer;

        }*/

        public void DeposerFonds(int fondsADeposer)
        {
            fondsDisponible += fondsADeposer;
        }

        public void AcheterDogeCoin(int quantite)
        {
            fondsDisponible = 0;
            //And it's gone
        }


        public enum ResultatOperation
        {
            OK,
            FondInsuffisant,
            RetraitTropVolumineux
        }
       
        public ResultatOperation RetirerFonds(int fondARetirer)
        {
            if (fondARetirer > 10000)
            {
                return ResultatOperation.RetraitTropVolumineux;
            }
            if (fondsDisponible < fondARetirer)
            {
                fraisDus++;// :)
            }
            if (fondsDisponible + LimiteADecouvert < fondARetirer)
            {
                return ResultatOperation.FondInsuffisant;
            }
            fondsDisponible -= fondARetirer;
            return ResultatOperation.OK;
        }

       

    }
}
