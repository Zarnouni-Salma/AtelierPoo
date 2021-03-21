using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Atelier1
{
    class Compte
    {
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
            
        }
      public Compte()
        {
            cmp++;
            this.num = cmp;
            this.titulaire = new Client();
            this.solde = new Mad(0);
            }
        public virtual void afficher()
        {
            Console.WriteLine("numero de compte est :" + this.num +" ");
            this.titulaire.afficher();
            Console.WriteLine("le solde  est :" + this.solde.ToString() + " ");
        }
        Mad zero = new Mad(0);
        public  bool crediter(Mad somme)
        {

            if (somme > zero)
            {
                this.solde += somme;
                return true;
            }
            else
                return false;
           
        }
        public  bool  debiter ( Mad somme)
        {
            Mad p = new Mad(5000);
            plafont = p;
            if (somme > zero && somme<=this.solde &&this.solde<plafont)
            {
                this.solde -= somme;
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
