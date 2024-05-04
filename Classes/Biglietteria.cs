using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoTreno
{
    public class Biglietteria()
    {
        public Biglietto CreaBiglietto(int tipo)
        { 

            return new Biglietto(tipo);
        }
    }

    public class Biglietto
    {
        string tipoBiglietto;
        int vagone, posto;

        internal Biglietto(int tipo) 
        {
            if (tipo == -1 || tipo == 0)
                tipoBiglietto = "SecondaClasse";
            else if (tipo == 1)
                tipoBiglietto = "PrimaClasse";
            else if (tipo == 2)
                tipoBiglietto = "FullOptional";
        }
    }
}
