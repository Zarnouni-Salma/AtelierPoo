using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Atelier1
{
    class AppBanque
    {
        public void dmr()
        {
            //Client
            Client c1 = new Client("zarnouni", "salma", "casablanca hm imm 16");
            Client c2 = new Client("zaroual", "lina", "casablanca borgone imm farah");
            //c1.afficher();
            //Console.WriteLine("---");
            //c2.afficher();
            //Console.WriteLine("---");
            //Mad

            Mad m = new Mad(150);
            Mad m2 = new Mad(100);
            //Compte
            Compte co3 = new Compte(m2, c1);
            Compte co1 = new Compte(m, c1);
            Compte co2 = new Compte(m, c2);
            //co1.afficher();
            //Console.WriteLine("---");
            co1.crediter(m);
            //Console.WriteLine("---");
            co1.afficher();
            //Console.WriteLine("---");
            co1.debiter(m);
            //Console.WriteLine("---");
            co1.afficher();
            co2.afficher();
            //testc verser
            Console.WriteLine("----------------");

            bool res = co1.verser(co2, m);
            if (res == true)
            {
                Console.WriteLine("Bien effectuée");
            }
            else
            {
                Console.WriteLine("Erreur");
            }
            Console.WriteLine("----------------");

            //compte_epargne
            Console.WriteLine("---");
            CompteE CompteEpargne1 = new CompteE(m, c1, 0.10);
            CompteEpargne1.afficher();
            CompteEpargne1.calculIntéret();
            CompteEpargne1.afficher();
            Console.WriteLine("---");
            //Compte_courant
            CompteC CompteCourant1 = new CompteC(m, c1);
            //CompteEpargne1.afficher();
            //CompteCourant1.verser(CompteEpargne1, m);
            //CompteEpargne1.afficher();

            //ajouter des comptes

            c1.ajouter(co1);
            c1.ajouter(co2);
            c1.afficher();
            //test methodes
         

            Console.WriteLine("---");


           
        }
  
    }
}
