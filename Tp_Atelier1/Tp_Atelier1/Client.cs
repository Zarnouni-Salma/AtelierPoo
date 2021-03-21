using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Tp_Atelier1
{
    class Client
    {
        private List<Compte> l;
        private readonly string nom;
        private string prenom;
        private string adresse;
        public Client()
        {
            this.nom = "";
            this.prenom = "";
            this.adresse = "";
            l = new List<Compte>();
        }
        public Client(string nom,string prenom,string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            l = new List<Compte>();
        }

        public void  afficher()
        {
            Console.WriteLine("le nom est :" + this.nom + " le prenom est :" + this.prenom + " l'adresse est :" + this.adresse);
            foreach (Compte f in l)
            {
                f.AfficherCompte();
            }
        }
    public void ajouter (Compte x)
        {
            l.Add(x);
      
        }


    }
}
