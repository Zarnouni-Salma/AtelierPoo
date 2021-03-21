using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Atelier1
{
    class CompteE:Compte
    {

        private double TauxInteret;
    
        public CompteE(Mad solde,Client c,double Taux):base(solde,c)
        {
            if (Taux > 0 && Taux < 100)
                this.TauxInteret = Taux;
            else
                throw new Exception("veuillez entrer une valeur entre 0 et 100");

        }
        public void calculIntéret()
        {
            Mad m = new Mad(TauxInteret);
            solde += solde * m;
            
        }
        

    }
}
