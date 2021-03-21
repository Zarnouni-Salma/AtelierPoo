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
            int i = 1;

            foreach (var o in l)
            {
                Console.WriteLine("l operation n " + i + " est " + o);
                
            }
        }
     
     
    }
}
