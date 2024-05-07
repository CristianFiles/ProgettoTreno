using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoTreno
{
    public abstract class Vagone(int posti)
    {
        internal readonly int posti = posti;
        internal int passeggeri = 0;
        internal int[] numeroposto = new int[posti];
        private int postIndex = 0;
        bool vagonePieno = false;
        public int PrimoLibero 
        {
            set
            {
                postIndex = value;
                if (postIndex == posti)
                {
                    passeggeri = posti;
                }
            }
            get => postIndex;
        }
        public abstract string TipoVagone();

        public int Disponibili
        {
            get => posti - passeggeri;
        }

        public virtual bool AccessoWIFI
        {
            get => false;
        }

        public virtual bool Caricatori 
        { 
            get => false;
        }

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
        public virtual Tuple<bool, int> ClusterSali(int saliti) 
        {
            int avanzati = passeggeri + saliti - posti;

            if (avanzati > 0)
            {
                vagonePieno = true;
                PrimoLibero = posti + 1;
                return new Tuple<bool, int>(false, avanzati);
            }
            else
            {
                PrimoLibero += saliti;
                return new Tuple<bool, int>(true, 0);
            }
        }

        //Metodo per far scendere più persone in una volta
        public virtual bool ClusterScendi(int scesi) 
        { 
            passeggeri -= scesi;
            if (passeggeri < 0)
                passeggeri = 0;
            return true;
        }
        
    }

    internal class PrimaClasse(int posti) : Vagone(posti)
    {
        public override bool AccessoWIFI => true;
        public override bool Caricatori => true;

        public override string TipoVagone()
        {
            return "PrimaClasse";
        }
    }

    internal class SecondaClasse(int posti) : Vagone(posti)
    {
        public override bool AccessoWIFI => true;
        public override string TipoVagone()
        {
            return "SecondaClasse";
        }
    }

    internal class Fumatori(int posti) : Vagone(posti)
    {
        public override string TipoVagone()
        {
            return "Fumatori";
        }
    }

    internal class Ristorante(int posti) : Vagone(posti)
    {
        public override bool Sali()
        {
            return false;
        }

        public override bool Scendi()
        {
            return false;
        }

        public override Tuple<bool, int> ClusterSali(int saliti)
        {
            return new Tuple<bool, int> (false, saliti);
        }

        public override bool ClusterScendi(int scesi)
        {
            return false;
        }

        public override string TipoVagone()
        {
            return "Ristorante";
        }
    }
    internal class Cuccette(int posti) : Vagone(posti)
    {
        public override bool AccessoWIFI => true;
        public override bool Caricatori => true;
        public override bool Sali()
        {
            return false;
        }

        public override bool Scendi()
        {
            return false;
        }

        public override Tuple<bool, int> ClusterSali(int saliti)
        {
            return new Tuple<bool, int>(false, saliti);
        }

        public override bool ClusterScendi(int scesi)
        {
            return false;
        }
        public override string TipoVagone()
        {
            return "Cuccette";
        }
    }


    internal class Silenzio(int posti) : Vagone(posti)
    {
        public override bool Sali()
        {
            return false;
        }

        public override bool Scendi()
        {
            return false;
        }

        public override Tuple<bool, int> ClusterSali(int saliti)
        {
            return new Tuple<bool, int>(false, saliti);
        }

        public override bool ClusterScendi(int scesi)
        {
            return false;
        }

        public override string TipoVagone()
        {
            return "Silenzio";
        }

    }

    
}
