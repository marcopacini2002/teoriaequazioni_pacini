using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        static public bool isDetermined(double a)
        {
            bool determinata;
            if (a!=0)
            {
                determinata = true;
            }
            else
            {
                determinata = false;
            }
            return determinata;
        }

        static public bool isInconsisted(double a,double b)
        {
            bool impossibile=false;
            if(a==0)
            {
                if(b!=0)
                {
                    impossibile = true;
                } 
            }
            return impossibile;
        }

        static public bool isIndeterminata(double a, double b)
        {
            bool indeterminata = false;
            if (a == 0)
            {
                if (b == 0)
                {
                    indeterminata = true;
                }
            }
            return indeterminata;
        }

        static public bool isDegree2(double a)
        {
            bool grado2=false;
            if (a != 0)
            {
                grado2 = true;
            }
            return grado2;
        }

        static public double Delta(double a, double b, double c)
        {
            double risultato;
            risultato = (b * b) - (4 * a * c);
            return risultato;
        }


        static public string Equazione(double a, double b)
        {
            string risultato = "";
            if (isIndeterminata(a, b) == true) risultato = "Indeterminato";
            if (isInconsisted(a, b) == true) risultato = "Impossibile";


            if (risultato == "")
            {
                risultato = $"x={-b / a}";


            }

            return risultato;
        }
    }
}
