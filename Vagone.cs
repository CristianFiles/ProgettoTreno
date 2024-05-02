using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoTreno
{
    internal abstract class Vagone
    {
        int posti;
        internal int passeggeri = 0;

        public Vagone(int posti, float prezzoPosto)
        {
            this.posti = posti;
            
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

    internal class PrimaClasse : Vagone
    {
        public PrimaClasse(int posti, float prezzoPosto) : base(posti, prezzoPosto) { }
    }

    internal class SecondaClasse : Vagone
    {
        public SecondaClasse(int posti, float prezzoPosto) : base(posti, prezzoPosto) { }
    }

    internal class Fumatori : Vagone
    {
        public Fumatori(int posti, float prezzoPosto) : base(posti, prezzoPosto) { }
    }

    internal class Ristorante : Vagone
    {
        public Ristorante(int posti, float prezzoPosto) : base(posti, prezzoPosto) { }

        public override bool Sali()
        {
            return false;
        }

        public override bool Scendi()
        {
            return false;
        }
    }
    internal class Cuccette : Vagone
    {
        public Cuccette(int posti, float prezzoPosto) : base(posti, prezzoPosto) { }

        public override bool Sali()
        {
            return false;
        }

        public override bool Scendi()
        {
            return false;
        }
    }


    internal class Silenzio : Vagone
    {
        public Silenzio(int posti, float prezzoPosto) : base(posti, prezzoPosto) { }

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
