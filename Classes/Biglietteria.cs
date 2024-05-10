using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgettoTreno
{
    public class Biglietteria()
    {
        public Biglietto CreaBiglietto(Biglietto.Tipi tipo, Biglietto.Destinazione dest, List<Vagone> Treno, string gen) => new Biglietto(tipo,dest, Treno, gen);
    }

    public class Biglietto
    {
        public string tipoBiglietto,destinazione, nomeCognome;
        public int vagone, posto;
        public DateTime dataCreazione;
        

        internal Biglietto(Tipi tipo,Destinazione dest, List<Vagone> Treno, string generalita) 
        {
            if (tipo == Tipi.FullOptional)
            {
                vagone = Treno.FindIndex(v => v.TipoVagone() == "Cuccette" && v.Disponibili > 0);
            }
            else
            {
                vagone = Treno.FindIndex(v => v.TipoVagone() == tipo.ToString() && v.Disponibili > 0);
            }
            //if (vagone == -1) MessageBox.Show("Non è stato possibile trovare un posto\nper questo tipo di biglietto");
            //else
            //{
                nomeCognome = generalita;
                dataCreazione = DateTime.Now;
                tipoBiglietto = tipo.ToString();
                Program.gestore.vagoneCorrente = Treno[vagone];
                destinazione = Regex.Replace(dest.ToString(), @"([a-z])([A-Z])", "$1 $2");
                posto = Treno[vagone].PrimoLibero;
                Treno[vagone].PrimoLibero++;
                Treno[vagone].passeggeri++;
            //}
        }

        public override string ToString()
        {
            return "Tipo biglietto: " + tipoBiglietto + "\nData e ora: " + dataCreazione.ToString("dd/MM/yyyy HH:mm") + "\nNumero vagone: " + (vagone + 1) + "\nNumero posto: " + (posto+1) + "\ndestinazione: " + destinazione + "\nnome e cognome: " + nomeCognome;
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
