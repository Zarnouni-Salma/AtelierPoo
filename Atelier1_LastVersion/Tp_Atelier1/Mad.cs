using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Atelier1
{
    class Mad
    {
        private double valeur;
        public Mad(double valeur)
        {
            this.valeur = valeur;
        }
        public void afficher()
        {
            Console.WriteLine("la valeur est" + valeur +" MAD");
        }
        public override string ToString()
        {
            return valeur + " MAD";
        }
        public static bool operator >(Mad m1,Mad m2)
        {
            if ((m1.valeur - m2.valeur) > 0)
                return true;
            else
                return false;
        }
        public static bool operator <(Mad m1, Mad m2)
        {
            if ((m1.valeur - m2.valeur)<0)
                return true;
            return false;

        }
        public static bool operator >=(Mad m1, Mad m2)
        {
            if ((m1.valeur - m2.valeur) >= 0)
                return true;
            else
                return false;
        }
        public static bool operator <=(Mad m1, Mad m2)
        {
            if ((m1.valeur - m2.valeur) <= 0)
                return true;
            return false;

        }
        public static Mad operator +(Mad m1,Mad m2)
        {
            double t=m1.valeur + m2.valeur;
            Mad m = new Mad(t);
            return m;
           // return new Mad(m1.valeur + m2.valeur);
        }
        public static Mad operator -(Mad m1, Mad m2)
        {
           
             return new Mad(m1.valeur - m2.valeur);
        }
    }
}
