using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Triangoli
{
    public class Gestione
    {
        public static double Area(double l1, double l2, double l3)
        {
            double sp = (l1 + l2 + l3) / 2;
            double media = Math.Sqrt(sp * (sp - l1) * (sp - l2) * (sp - l3));
            return media;
        }

        public static string OutputTrangolo(double l1, double l2, double l3)
        {
            string triangolo = "";
            if (l1 == l2 && l1 == l3)
            {
                triangolo = "equilatero";
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                triangolo = "isoscele";
            }
            else
            {
                triangolo = "scaleno";
            }
            return triangolo;
        }




    }
}
