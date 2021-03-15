using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Atelier1
{
    class Client
    {
        private readonly string nom;
        private string prenom;
        private string adresse;
        public Client(string nom,string prenom,string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }

        public void  afficher()
        {
            Console.WriteLine("le nom est :" + this.nom + " le prenom est :" + this.prenom + " l'adresse est :" + this.adresse);
        }
       

    }
}
