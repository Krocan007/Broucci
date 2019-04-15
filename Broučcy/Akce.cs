﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broucy
{
    abstract public class Akce
    {
        abstract public void UpravBroucka(Brouk brouk);
    }
    class OtocDoprava : Akce
    {
        public override void UpravBroucka(Brouk brouk)
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
    class OtocDoleva : Akce
    {
        public override void UpravBroucka(Brouk brouk)
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
    class Jdi : Akce
    {
        public override void UpravBroucka(Brouk brouk)
        {
            switch (brouk.otoceni)
            {
                case Brouk.Otoceni.nahoru:
                    brouk.souradnice.y = (brouk.souradnice.y - 1)%brouk.mapa.rozmer;
                    break;
                case Brouk.Otoceni.dolu:
                    brouk.souradnice.y = (brouk.souradnice.y + 1) % brouk.mapa.rozmer;
                    break;
                case Brouk.Otoceni.doprava:
                    brouk.souradnice.x = (brouk.souradnice.x + 1) % brouk.mapa.rozmer;
                    break;
                case Brouk.Otoceni.doleva:
                    brouk.souradnice.x = (brouk.souradnice.x - 1) % brouk.mapa.rozmer;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
