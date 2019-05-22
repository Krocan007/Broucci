using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Broucy
{
    public class Brouk
    {
        public Brouk(Mapa mapa, Souradnice souradnice, Otoceni otoceni,TabulkaPrikazu TabulkaPrikazu)
        {
            this.mapa = mapa;
            this.souradnice = souradnice;
            this.otoceni = otoceni;
            this.TabulkaPrikazu = TabulkaPrikazu;

        }
        internal Mapa mapa;
        public Souradnice souradnice;
        public enum Otoceni { nahoru, dolu, doprava, doleva }
        public Otoceni otoceni { get; internal set; }
        internal int stav;
        private TabulkaPrikazu TabulkaPrikazu;
        public int SezranejchKytek;

        public void UdelejTah()
        {
            Prikaz p = TabulkaPrikazu.VratPrikaz(stav);
            Mapa.Predmety predmet = VratCoJePredeMnou();
            switch (predmet)
            {
                case Mapa.Predmety.Prazdno:
                    p.Prazdno.UpravBroucka(this,predmet);
                    stav = p.NovyStavPrazdno;
                    break;
                case Mapa.Predmety.Prekazka:
                    p.Prekazka.UpravBroucka(this,predmet);
                    stav = p.NovyStavPrekazka;
                    break;
                case Mapa.Predmety.Kytka:
                    p.Kytka.UpravBroucka(this,predmet);
                    mapa[souradnice.x, souradnice.y] = Mapa.Predmety.Prazdno;
                    stav = p.NovyStavKytka;
                    break;
                default:
                    throw new NotImplementedException();
            }

        }
        private Mapa.Predmety VratCoJePredeMnou()
        {
            switch (otoceni)
            {
                case Otoceni.nahoru:
                    return mapa[souradnice.x, souradnice.y - 1];
                case Otoceni.dolu:
                    return mapa[souradnice.x, souradnice.y + 1];
                case Otoceni.doprava:
                    return mapa[souradnice.x+1, souradnice.y];
                case Otoceni.doleva:
                    return mapa[souradnice.x-1, souradnice.y];
                default:
                    throw new NotImplementedException();
            }
        }
    }

}
