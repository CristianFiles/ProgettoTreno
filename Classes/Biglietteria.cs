using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoTreno
{
    public class Biglietteria()
    {
        public Biglietto CreaBiglietto(Biglietto.Tipi tipo, List<Vagone> Treno) => new Biglietto(tipo, Treno);
    }

    public class Biglietto
    {
        public string tipoBiglietto;
        public int vagone, posto;

        internal Biglietto(Tipi tipo, List<Vagone> Treno) 
        {
            tipoBiglietto = tipo.ToString();
            vagone = Treno.FindIndex(v => v.TipoVagone() == tipoBiglietto && v.Disponibili > 0);
            posto = Treno[vagone].PrimoLibero;
            Treno[vagone].PrimoLibero++;
        }
        public enum Tipi
        {
            SecondaClasse,
            PrimaClasse,
            FullOptional
        }
    }
}
