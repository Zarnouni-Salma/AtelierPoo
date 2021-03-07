using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_banque
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

          
            Compte c1 = new Compte("zarnouni","salma","casablanca hm imm 16 n 14",100.00);
            c1.afficher();

            Console.WriteLine("---------"); 

            c1.retirerSolde(98);
            c1.afficher();

            Console.WriteLine("---------");
          
            Compte c2 = new Compte("zarnouni", "salma", "casablanca hm imm 16 n 14", 200.00);
            c2.afficher();

            Console.WriteLine("---------");

            c2.trasferer(50,c1);
            c2.afficher();
            c1.afficher();





            Console.ReadKey();
        }
    }
}
