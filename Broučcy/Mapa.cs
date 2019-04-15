using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broucy
{
    public struct Souradnice
    {
        public int x, y;
    }
    public class TabulkaPrikazu
    {
        public TabulkaPrikazu(Prikaz [] prikazy)
        {
            this.prikazy = prikazy;
        }
        public Prikaz VratPrikaz(int Stav)
        {
            return prikazy [Stav];
        }
        Prikaz[] prikazy;
    }
    public class Prikaz
    {
        public Akce Kytka, Prazdno, Prekazka;
        public int NovyStavKytka, NovyStavPrazdno, NovyStavPrekazka;
    }
    public class Mapa
    {

        public Mapa(int n)
        {
            mapa = new Predmety[n, n];
            this.rozmer = n;
        }

        public enum Predmety { Prazdno, Prekazka, Kytka };
        private Predmety [,] mapa;
        public int rozmer;

        public Predmety this[Souradnice s]
        {
            get
            {
                return mapa[(s.x + rozmer) % rozmer, (s.y+rozmer) % rozmer];
            }
            set
            {
                mapa[(s.x + rozmer) % rozmer, (s.y+rozmer) % rozmer] = value;
            }
        }

        public Predmety this[int x, int y]
        {
            get
            {
                return mapa[(x + rozmer) % rozmer, (y+rozmer) % rozmer];
            }
            set
            {
                mapa[(x + rozmer) % rozmer, (y+rozmer) % rozmer] = value;
            }
        }
    }
}
