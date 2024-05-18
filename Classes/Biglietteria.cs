using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgettoTreno
{
    public class Biglietto
    {
        public string tipoBiglietto,destinazione, nomeCognome;
        public int vagone, posto;
        public DateTime dataCreazione;
        

        internal Biglietto(string tipo, string dest, List<Vagone> Treno, string generalita) 
        {
            //Potrebbe esserci un problema se si cerca di creare un biglietto per un vagone già pieno
            vagone = Treno.FindIndex(v => v.bigliettiAccessibili.Contains(tipo.ToString()) && v.bigliettiAccessibili.Count() == 1 && v.Disponibili > 0);
            //if (vagone == -1) MessageBox.Show("Non è stato possibile trovare un posto\nper questo tipo di biglietto");
            //else
            //{
            nomeCognome = generalita;
            dataCreazione = DateTime.Now;
            tipoBiglietto = tipo;
            Program.gestore.vagoneCorrente = Treno[vagone];
            destinazione = dest;
            posto = Treno[vagone].PrimoLibero;
            Treno[vagone].PrimoLibero++;
            Treno[vagone].passeggeri++;
            //}
        }

        public override string ToString() => "Tipo biglietto: " + tipoBiglietto + "\nData e ora: " + dataCreazione.ToString("dd/MM/yyyy HH:mm") + "\nNumero vagone: " + (vagone + 1) + "\nNumero posto: " + (posto + 1) + "\ndestinazione: " + destinazione + "\nnome e cognome: " + nomeCognome;

        //Odio il fatto che ci sono solo enum di interi
        public static class Tipi 
        {
            public static readonly string SecondaClasse = "Seconda Classe";
            public static readonly string PrimaClasse = "Prima Classe";
            public static readonly string FullOptional = "Full Optional";

            public static IEnumerable<string> Values{
                get
                {
                    yield return SecondaClasse;
                    yield return PrimaClasse;
                    yield return FullOptional;
                }
            }
        }
        public static class Destinazione 
        {
            public static readonly string Abruzzo = "Abruzzo";
            public static readonly string Basilicata = "Basilicata";
            public static readonly string Calabria = "Calabria";
            public static readonly string Campania = "Campania";
            public static readonly string EmiliaRomagna = "Emilia-Romagna";
            public static readonly string FriuliVeneziaGiulia = "Friuli-Venezia Giulia";
            public static readonly string Lazio = "Lazio";
            public static readonly string Liguria = "Liguria";
            public static readonly string Lombardia = "Lombardia";
            public static readonly string Marche = "Marche";
            public static readonly string Molise = "Molise";
            public static readonly string Piemonte = "Piemonte";
            public static readonly string Puglia = "Puglia";
            public static readonly string Sardegna = "Sardegna";
            public static readonly string Sicilia = "Sicilia";
            public static readonly string Toscana = "Toscana";
            public static readonly string TrentinoAltoAdige = "Trentino-Alto Adige";
            public static readonly string Umbria = "Umbria";
            public static readonly string ValDaosta = "Valle d'Aosta";
            public static readonly string Veneto = "Veneto";

            public static IEnumerable<string> Values
            {
                get
                {
                    yield return Abruzzo;
                    yield return Basilicata;
                    yield return Calabria;
                    yield return Campania;
                    yield return EmiliaRomagna;
                    yield return FriuliVeneziaGiulia;
                    yield return Lazio;
                    yield return Liguria;
                    yield return Lombardia;
                    yield return Marche;
                    yield return Molise;
                    yield return Piemonte;
                    yield return Puglia;
                    yield return Sardegna;
                    yield return Sicilia;
                    yield return Toscana;
                    yield return TrentinoAltoAdige;
                    yield return Umbria;
                    yield return ValDaosta;
                    yield return Veneto;
                }
            }
        }
    }
}
