using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoTreno
{
    public class Biglietteria()
    {
        public Biglietto CreaBiglietto(int tipo, List<Vagone> Treno)
        { 

            return new Biglietto(tipo, Treno);
        }
    }

    public class Biglietto
    {
        public string tipoBiglietto;
        public int vagone, posto;

        internal Biglietto(int tipo, List<Vagone> Treno) 
        {
            int i = 0;
            if (tipo == -1 || tipo == 0)
            {
                tipoBiglietto = "SecondaClasse";
            }
            else if (tipo == 1)
            {
                tipoBiglietto = "PrimaClasse";
            }
            else if (tipo == 2)
            {
                tipoBiglietto = "FullOptional";
            }


            if (tipoBiglietto == "FullOptional")
            {
                for (i = 0; i < Treno.Count; i++)
                {
                    if (Treno[i].TipoVagone() == "Cuccette")
                    {
                        if (Treno[i].Disponibili > 0)
                        {
                            vagone = i;
                            posto = Treno[i].PrimoLibero;
                            Treno[i].PrimoLibero++;
                            break;
                        }
                    }
                }
            }


            for (i = 0; i < Treno.Count; i++)
            {
                if (Treno[i].TipoVagone() == tipoBiglietto)
                {
                    if (Treno[i].Disponibili > 0)
                    {
                        vagone = i;
                        posto = Treno[i].PrimoLibero;
                        Treno[i].PrimoLibero++;
                        break;
                    }
                }

            }
            
        }

        
    }
}
