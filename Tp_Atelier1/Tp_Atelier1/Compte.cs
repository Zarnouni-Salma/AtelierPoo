using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Atelier1
{
  class Compte
    {
        private List<Operation> l;
       protected int num;
       protected Mad solde;
        protected static int cmp;
        protected readonly Client titulaire;
        
        protected static Mad plafont;
        public Compte(Mad solde, Client c)
        {
            cmp++;
            this.num = cmp;
            this.solde = solde;
            this.titulaire = c;
            l = new List<Operation>();
            
        }
      public Compte()
        {
            cmp++;
            this.num = cmp;
            this.titulaire = new Client();
            this.solde = new Mad(0);
            l = new List<Operation>();
            }
        public virtual void afficher()
        {
            Console.WriteLine("numero de compte est :" + this.num +" ");
            this.titulaire.afficher();
            Console.WriteLine("le solde  est :" + this.solde.ToString() + " ");
            Console.WriteLine("liste des operations: ");
            int i = 0;
            if (this.l.Count==0)
            {
                Console.WriteLine("pas d'operation pour le moment ");
            }
            else
            {
                foreach (Operation o in l)
                {
                    i++;
                    Console.WriteLine("l operation n " + i + " est ");
                    o.afficher();

                }
            }

        }
        Mad zero = new Mad(0);
        public  bool crediter(Mad somme)
        {

            if (somme > zero)
            {
                this.solde += somme;
                l.Add(new Operation(somme, "+"));
                return true;
            }
            else
                return false;
           
        }
        public virtual bool  debiter ( Mad somme)
        {
            Mad p = new Mad(5000);
            plafont = p;
            if (somme > zero && somme<=this.solde &&this.solde<plafont)
            {
                this.solde -= somme;
                l.Add(new Operation(somme, "-"));
                return true;
            }
            else
                return false;

        }
      
        public  bool verser( Compte c, Mad somme)
        {
           return this.debiter(somme) && c.crediter(somme);
            
        }
        public void AfficherCompte()
        {
            Console.WriteLine("numero est :" + this.num);
            Console.WriteLine("solde est  : " + solde.ToString());
        }
    }
}
