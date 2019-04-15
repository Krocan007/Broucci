using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Broucy
{
    public class Brouk
    {
        public Brouk(Mapa mapa, Souradnice souradnice, Otoceni otoceni)
        {
            this.mapa = mapa;
            this.souradnice = souradnice;
            this.otoceni = otoceni;
        }
        internal Mapa mapa;
        public Souradnice souradnice { get; internal set; }
        public enum Otoceni { nahoru, dolu, doprava, doleva }
        public Otoceni otoceni { get; internal set; }
        internal int stav;

        public void UdelejTah()
        {

        }
    }

}
