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
  
        private int postIndex = 0;
        bool vagonePieno = false;

        public virtual string[] bigliettiAccessibili 
        {
            get
            {
                return ["SecondaClasse", "PrimaClasse", "FullOptional"];
            }
        }
        public int PrimoLibero 
        {
            set => postIndex = value;
            get => postIndex;
        }
        public abstract string TipoVagone();

        public int Disponibili => posti - passeggeri;

        public virtual bool AccessoWIFI => false;

        public virtual bool Caricatori => false;

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
                vagonePieno = true;
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

        public Vagone Sposta(Vagone altro) 
        {
            if (altro.Disponibili > 0)
            {
                altro.passeggeri++;
                altro.PrimoLibero++;
                passeggeri--;
                PrimoLibero--;
                return altro;
            }
            else
            {
                MessageBox.Show("Vagone selezionato pieno!");
                return this;
            }
        }
    }

    public class PrimaClasse(int posti) : Vagone(posti)
    {
        public override string TipoVagone() => "PrimaClasse";
        public override bool AccessoWIFI => true;
        public override bool Caricatori => true;
        public override string[] bigliettiAccessibili => ["PrimaClasse"];
    }

    internal class SecondaClasse(int posti) : Vagone(posti)
    {
        public override string TipoVagone() => "SecondaClasse";
        public override bool Caricatori => true;
        public override string[] bigliettiAccessibili => ["SecondaClasse"];
    }

    internal class Fumatori(int posti) : Vagone(posti)
    {
        public override string TipoVagone() => "Fumatori";
        public override int ClusterSali(int saliti) => saliti;
        public override bool ClusterScendi(int scesi) => false;
    }

    internal class Ristorante(int posti) : Vagone(posti)
    {
        public override string TipoVagone() => "Ristorante";
        public override bool Sali() => false;
        public override bool Scendi() => false;
        public override int ClusterSali(int saliti) => saliti;
        public override bool ClusterScendi(int scesi) => false;
        public override string[] bigliettiAccessibili => ["PrimaClasse", "FullOptional"];
    }

    internal class Cuccette(int posti) : Vagone(posti)
    {
        public override string TipoVagone() => "Cuccette";
        public override bool AccessoWIFI => true;
        public override bool Caricatori => true;
        public override bool Sali() => false;
        public override bool Scendi() => false;
        public override int ClusterSali(int saliti) => saliti;
        public override bool ClusterScendi(int scesi) => false;
        public override string[] bigliettiAccessibili => ["FullOptional"];
    }

    internal class Silenzio(int posti) : Vagone(posti)
    {
        public override string TipoVagone() => "Silenzio";
        public override bool AccessoWIFI => true;
        public override bool Sali() => false;
        public override bool Scendi() => false;
        public override int ClusterSali(int saliti) => saliti;
        public override bool ClusterScendi(int scesi) => false;
        public override string[] bigliettiAccessibili => ["PrimaClasse", "FullOptional"];
    }

    public enum TipoVagone
    { 
        PrimaClasse,
        SecondaClasse,
        Cuccette,
        Silenzio,
        Ristorante,
        Fumatori
    }
}
