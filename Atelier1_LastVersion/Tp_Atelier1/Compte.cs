using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Atelier1
{
    class Compte
    {
        private int num;
        private Mad solde;
        static int cmp;
        private readonly Client titulaire;
        
        static Mad plafont;
        public Compte(Mad solde, Client c)
        {
            cmp++;
            this.num = cmp;
            this.solde = solde;
            this.titulaire = c;
            
        }
        public void afficher()
        {
            Console.WriteLine("numero de compte est :" + this.num +" ");
            this.titulaire.afficher();
            Console.WriteLine("le solde  est :" + this.solde.ToString() + " ");
        }
        Mad zero = new Mad(0);
        public bool crediter(Mad somme)
        {

            if (somme > zero)
            {
                this.solde += somme;
                return true;
            }
            else
                return false;
           
        }
        public bool  debiter ( Mad somme)
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
        public bool verser( Compte c, Mad somme)
        {
           return this.debiter(somme) && c.crediter(somme);
            
        }
    }
}
