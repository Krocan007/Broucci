﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broucy
{
    public abstract class Akce
    {
        abstract public void UpravBroucka(Brouk brouk, Mapa.Predmety predmet);
    }
    public class OtocDoprava : Akce
    {
        public static OtocDoprava Instance { get; } = new OtocDoprava();
        private OtocDoprava() { }

        public override void UpravBroucka(Brouk brouk, Mapa.Predmety predmet)
        {
            switch (brouk.otoceni)
            {
                case Brouk.Otoceni.nahoru:
                    brouk.otoceni = Brouk.Otoceni.doleva;
                    break;
                case Brouk.Otoceni.dolu:
                    brouk.otoceni = Brouk.Otoceni.doprava;
                    break;
                case Brouk.Otoceni.doprava:
                    brouk.otoceni = Brouk.Otoceni.dolu;
                    break;
                case Brouk.Otoceni.doleva:
                    brouk.otoceni = Brouk.Otoceni.nahoru;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
    public class OtocDoleva : Akce
    {
        public static OtocDoleva Instance { get; } = new OtocDoleva();
        private OtocDoleva() { }

        public override void UpravBroucka(Brouk brouk,Mapa.Predmety predmet)
        {
            switch (brouk.otoceni)
            {
                case Brouk.Otoceni.nahoru:
                    brouk.otoceni = Brouk.Otoceni.doprava;
                    break;
                case Brouk.Otoceni.dolu:
                    brouk.otoceni = Brouk.Otoceni.doleva;
                    break;
                case Brouk.Otoceni.doprava:
                    brouk.otoceni = Brouk.Otoceni.nahoru;
                    break;
                case Brouk.Otoceni.doleva:
                    brouk.otoceni = Brouk.Otoceni.dolu;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
    public class Jdi : Akce
    {
        public static Jdi Instance { get; } = new Jdi();
        private Jdi() { }

        public override void UpravBroucka(Brouk brouk, Mapa.Predmety predmet)

        {
            switch (predmet)
            {
                case Mapa.Predmety.Prekazka:
                    break;
                case Mapa.Predmety.Prazdno:
                    switch (brouk.otoceni)
                    {
                        case Brouk.Otoceni.nahoru:
                            brouk.souradnice.y = ((brouk.souradnice.y - brouk.mapa.rozmer) % brouk.mapa.rozmer) + brouk.mapa.rozmer - 1;
                            break;
                        case Brouk.Otoceni.dolu:
                            brouk.souradnice.y = (brouk.souradnice.y + 1) % brouk.mapa.rozmer;
                            break;
                        case Brouk.Otoceni.doprava:
                            brouk.souradnice.x = (brouk.souradnice.x + 1) % brouk.mapa.rozmer;
                            break;
                        case Brouk.Otoceni.doleva:
                            brouk.souradnice.x = (brouk.souradnice.x - brouk.mapa.rozmer) % brouk.mapa.rozmer + brouk.mapa.rozmer - 1;
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    break;
                case Mapa.Predmety.Kytka:
                    brouk.SezranejchKytek += 1;
                    switch (brouk.otoceni)
                    {
                        case Brouk.Otoceni.nahoru:
                            brouk.souradnice.y = ((brouk.souradnice.y - brouk.mapa.rozmer) % brouk.mapa.rozmer) + brouk.mapa.rozmer - 1;
                            break;
                        case Brouk.Otoceni.dolu:
                            brouk.souradnice.y = (brouk.souradnice.y + 1) % brouk.mapa.rozmer;
                            break;
                        case Brouk.Otoceni.doprava:
                            brouk.souradnice.x = (brouk.souradnice.x + 1) % brouk.mapa.rozmer;
                            break;
                        case Brouk.Otoceni.doleva:
                            brouk.souradnice.x = (brouk.souradnice.x - brouk.mapa.rozmer) % brouk.mapa.rozmer + brouk.mapa.rozmer - 1;
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
            
        }
    }
}
