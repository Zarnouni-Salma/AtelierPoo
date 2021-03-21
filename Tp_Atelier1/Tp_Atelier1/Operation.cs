using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Atelier1
{
    class Operation
    {
        private int numero;
        private DateTime date;
        private Mad Montant;
        private string libelle;
     public Operation()
        {
            this.numero = 0;
         
        }
        public Operation(int numero,Mad m,string libelle)
     {
         this.numero = numero;
         this.date = DateTime.Now;
         this.Montant = m;
         this.libelle = libelle;
     }
        public void afficher()
        {
            Console.WriteLine(this.date+ "| n° " +this.numero+ "|  " +this.libelle+ "|  " +this.Montant);
        }

    }
}
