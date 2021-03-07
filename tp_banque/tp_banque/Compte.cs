using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_banque
{
    class Compte
    {
         public static int cmp;
        private string nom, prenom, adresse;
        private int numero;
        private double solde;
       public Compte()
        {
            cmp++;
            this.numero = cmp;
            this.nom = "";
            this.prenom = "";
            this.adresse = "";
            this.solde = 0;

        }
        public Compte(string nom,string prenom,string adresse,double solde) 
        {
            cmp++;
            this.numero = cmp;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.solde = solde;
        }
        public void afficher()
        {
            Console.WriteLine("le numero de compte est :" + this.numero + "  le nom est : " + this.nom + "  le prenom est : " + this.prenom + "  l adresse est : " + this.adresse + " le solde est :"+this.solde+ " MAD");
        }
        public void ajouterSolde(double s)
        {
            if(s>0)
            {
                this.solde += s;
            }
        }
        public void retirerSolde(double s)
        {

            double max = 1000.00;
            if (s > 0)
            {
                if (this.solde > 0)
                {
                    if (s > max)
  
                 
                        Console.WriteLine("la valeur maximal autorisé est 1000 , veuillez réessayer a nouveau !!");
                   
                       else if (s > this.solde)

                        Console.WriteLine(" solde insuffisant ,veuillez entrer une somme inférieure !!");
                    else
                        this.solde -= s;
                    Console.WriteLine("votre opération a été effectuée avec succés");

                }

                else
                    Console.WriteLine("le compte a zero dhs !!");



            }
            else
            {
                Console.WriteLine("veuillez entrer une valeur positif s'il vous plait !!");
            }
          
        }
        public void trasferer(double somme,Compte c)
        {

            if (somme>0)
            {
                this.retirerSolde(somme);
               
                c.ajouterSolde(somme);

            }
        }
    }
}
