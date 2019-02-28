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
    }
}
