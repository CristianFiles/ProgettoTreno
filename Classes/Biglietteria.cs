using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgettoTreno
{
    public class Biglietteria()
    {
        public Biglietto CreaBiglietto(Biglietto.Tipi tipo, Biglietto.Destinazione dest, List<Vagone> Treno) => new Biglietto(tipo,dest, Treno);
    }

    public class Biglietto
    {
        public string tipoBiglietto,destinazione;
        public int vagone, posto;
        

        internal Biglietto(Tipi tipo,Destinazione dest, List<Vagone> Treno) 
        {
            tipoBiglietto = tipo.ToString();
            destinazione= Regex.Replace(dest.ToString(), @"([a-z])([A-Z])", "$1 $2");
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
        public enum Destinazione 
        {
            Abruzzo,
            Basilicata,
            Calabria,
            Campania,
            EmiliaRomagna,
            FriuliVeneziaGiulia,
            Lazio,
            Liguria,
            Lombardia,
            Marche,
            Molise,
            Piemonte,
            Puglia,
            Sardegna,
            Sicilia,
            Toscana,
            TrentinoAltoAdige,
            Umbria,
            ValDaosta,
            Veneto
        }
    }
}
