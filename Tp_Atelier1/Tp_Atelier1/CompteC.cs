using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Atelier1
{
    class CompteC:Compte
    {
        List<Operation> l;
        private Mad découvert;
        Mad m = new Mad(0.0);
        public CompteC(Mad solde, Client c):base(solde,c)
        {
            découvert = new Mad(50);
            l = new List<Operation>();

        }
      
        public void Afficher()
        {
          
        }

        public override bool debiter(Mad somme)
        {

            if (solde - somme >= découvert)
            {
                return base.debiter(somme);
            }
            else
            {
                Console.WriteLine("veuillez respecter svp le decouvert");
                return false;
            }

        }
     
     
    }
}
