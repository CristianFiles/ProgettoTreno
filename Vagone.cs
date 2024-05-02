using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoTreno
{
    internal abstract class Vagone(int posti)
    {
        private readonly int posti = posti;
        internal int passeggeri = 0;
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

        public int Disponibili
        {
            get => posti - passeggeri;
        }
    }

    internal class PrimaClasse(int posti) : Vagone(posti)
    {
        public override bool AccessoWIFI => true;
        public override bool Caricatori => true;
    }

    internal class SecondaClasse(int posti) : Vagone(posti)
    {
        public override bool AccessoWIFI => true;
    }

    internal class Fumatori(int posti) : Vagone(posti)
    {
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
    }
}
