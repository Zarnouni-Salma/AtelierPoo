using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Atelier1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client("zarnouni", "salma", "casablanca hm imm 16");
            Client c2 = new Client("zaroual", "lina", "casablanca borgone imm farah");
            c1.afficher();
            Console.WriteLine("---");
            c2.afficher();
            Console.WriteLine("---");

            Mad m = new Mad(150);
            Compte co1 = new Compte(m, c1);
            Compte co2 = new Compte(m, c2);
            co1.afficher();
            Console.WriteLine("---");
            co1.crediter(m);
            Console.WriteLine("---");
            co1.afficher();
            Console.WriteLine("---");
            co1.debiter(m);
            Console.WriteLine("---");

            bool res = co1.verser(co2,m);
            Console.WriteLine(res);

            Console.ReadKey();
            
        }
    }
}
