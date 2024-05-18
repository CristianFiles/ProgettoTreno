using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoTreno
{
    public abstract class Vagone(int posti)
    {
        internal readonly int posti = posti;
        internal int passeggeri = 0;
        public int PrimoLibero { get; set;} = 0;
        public int Disponibili => posti - passeggeri;
        public virtual bool AccessoWIFI => false;
        public virtual bool Caricatori => false;

        public abstract TipiVagone TipoVagone();

        public virtual string[] bigliettiAccessibili => [Biglietto.Tipi.SecondaClasse, Biglietto.Tipi.PrimaClasse, Biglietto.Tipi.FullOptional];
        
        public virtual bool Scendi() 
        {
            passeggeri--;
            if(passeggeri < 0)
                passeggeri = 0;
            return true;
        }
        public virtual bool Sali() 
        {
            if (Disponibili > 0)
            {
                passeggeri++;
                return true;
            }
            return false;
        }

        //Metodo per far salire più persone in una volta, ritorna il numero di passeggeri che non sono riusciti a salire su questo vagone
        public virtual int ClusterSali(int saliti) 
        {
            int avanzati = passeggeri + saliti - posti;
            passeggeri += saliti;
            if (passeggeri > posti)
                passeggeri = posti;
            if (avanzati > 0)
            {
                PrimoLibero = posti + 1;
                return avanzati;
            }
            else
            {
                PrimoLibero += saliti;
                return 0;
            }
        }

        //Metodo per far scendere più persone in una volta
        public virtual bool ClusterScendi(int scesi) 
        { 
            passeggeri -= scesi;
            PrimoLibero -= scesi;
            if (passeggeri < 0)
            {
                passeggeri = 0;
                PrimoLibero = 0;
            }
            return true;
        }

        public virtual bool Accessibile(Biglietto biglietto) 
        {
            if(bigliettiAccessibili.Contains(biglietto.tipoBiglietto)) return true;
            else return false;
        }

        public Vagone Sposta(Vagone altro, List<Biglietto> bigl) 
        {
            int pers = bigl.Count();
            if (altro.Disponibili >= pers)
            {
                altro.passeggeri += pers;
                altro.PrimoLibero += pers;
                passeggeri  -= pers;
                PrimoLibero -= pers;
                return altro;
            }
            else
            {
                MessageBox.Show("Questo vagone non ha abbastanza posti!");
                return this;
            }
        }

        public int ClusterSposta(Vagone vagone, int spostati)
        {
            if (passeggeri < spostati) MessageBox.Show("Non ci sono abbastanza passeggeri!");
            else
            {
                if (vagone.Disponibili <= spostati)
                {
                    spostati -= vagone.Disponibili;
                    passeggeri -= vagone.Disponibili;
                    PrimoLibero -= vagone.Disponibili;
                    vagone.passeggeri = vagone.posti;
                    vagone.PrimoLibero = vagone.posti + 1;
                }
                else
                {
                    passeggeri -= spostati;
                    PrimoLibero -= spostati;
                    vagone.passeggeri += spostati;
                    vagone.PrimoLibero += spostati;
                    spostati = 0;
                }
            }
            return spostati;
        }
    }

    public class PrimaClasse(int posti) : Vagone(posti)
    {
        public override TipiVagone TipoVagone() => TipiVagone.PrimaClasse;
        public override bool AccessoWIFI => true;
        public override bool Caricatori => true;
        public override string[] bigliettiAccessibili => [Biglietto.Tipi.PrimaClasse];
    }

    internal class SecondaClasse(int posti) : Vagone(posti)
    {
        public override TipiVagone TipoVagone() => TipiVagone.SecondaClasse;
        public override bool Caricatori => true;
        public override string[] bigliettiAccessibili => [Biglietto.Tipi.SecondaClasse];
    }

    internal class Fumatori(int posti) : Vagone(posti)
    {
        public override TipiVagone TipoVagone() => TipiVagone.Fumatori;
        public override int ClusterSali(int saliti) => saliti;
        public override bool ClusterScendi(int scesi) => false;
    }

    internal class Ristorante(int posti) : Vagone(posti)
    {
        public override TipiVagone TipoVagone() => TipiVagone.Ristorante;
        public override bool Sali() => false;
        public override bool Scendi() => false;
        public override int ClusterSali(int saliti) => saliti;
        public override bool ClusterScendi(int scesi) => false;
        public override string[] bigliettiAccessibili => [Biglietto.Tipi.PrimaClasse, Biglietto.Tipi.FullOptional];
    }

    internal class Cuccette(int posti) : Vagone(posti)
    {
        public override TipiVagone TipoVagone() => TipiVagone.Cuccette;
        public override bool AccessoWIFI => true;
        public override bool Caricatori => true;
        public override bool Sali() => false;
        public override bool Scendi() => false;
        public override int ClusterSali(int saliti) => saliti;
        public override bool ClusterScendi(int scesi) => false;
        public override string[] bigliettiAccessibili => [Biglietto.Tipi.FullOptional];
    }

    internal class Silenzio(int posti) : Vagone(posti)
    {
        public override TipiVagone TipoVagone() => TipiVagone.Silenzio;
        public override bool AccessoWIFI => true;
        public override bool Sali() => false;
        public override bool Scendi() => false;
        public override int ClusterSali(int saliti) => saliti;
        public override bool ClusterScendi(int scesi) => false;
        public override string[] bigliettiAccessibili => [Biglietto.Tipi.PrimaClasse, Biglietto.Tipi.FullOptional];
    }

    public enum TipiVagone
    { 
        PrimaClasse,
        SecondaClasse,
        Cuccette,
        Silenzio,
        Ristorante,
        Fumatori
    }
}
