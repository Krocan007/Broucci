using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Broucy;

namespace ObrazovkaProBroucky
{
    struct MapaBrouk
    {
        public Brouk brouk;
        public Mapa mapa;
    }

    class TestData
    {
        public static Mapa emptyMap = new Mapa(30);

        //V tyhle funkci si muzes napsat co chces, bude to ten brouk a mapa co pobezi v okynku
        //Navratova hodnota je teda brouk zabalena ve strukture MapaBrouk
        //Velikost mapy si muzes zvolit, automaticky se to nastavi jak potrebujes - predpokladam, jedine co urcuje rozmerry mapy je promena rozmer
        public static MapaBrouk VyrobBroukaSMapou()
        {
            // Prikaz prvni = new Prikaz()
            // {
            //     Kytka = Jdi.Instance,
            //     NovyStavKytka = 0,
            //
            //     Prekazka = OtocDoprava.Instance,
            //     NovyStavPrekazka = 1,
            //
            //     Prazdno = Jdi.Instance,
            //     NovyStavPrazdno = 1
            // };
            //
            // Prikaz druhy = new Prikaz()
            // {
            //     Kytka = Jdi.Instance,
            //     NovyStavKytka = 0,
            //
            //     Prekazka = OtocDoprava.Instance,
            //     NovyStavPrekazka = 1,
            //
            //     Prazdno = Jdi.Instance,
            //     NovyStavPrazdno = 1
            // };
            //
            // TabulkaPrikazu tabulka = new TabulkaPrikazu(new Prikaz[] { prvni, druhy });

            Generátor G = new Generátor(10);
            TabulkaPrikazu tabulka = G.VytvorNahodnouTabulku();
            Mapa novaMapa = new Mapa(20);
            novaMapa[3, 3] = Mapa.Predmety.Prekazka;
            novaMapa[3, 2] = Mapa.Predmety.Prekazka;
            novaMapa[3, 1] = Mapa.Predmety.Prekazka;
            novaMapa[3, 0] = Mapa.Predmety.Prekazka;

            Brouk novyBrouk = new Brouk(novaMapa, new Souradnice() { x = 0, y = 0 }, Brouk.Otoceni.doprava, tabulka);

            return new MapaBrouk() { mapa = novaMapa, brouk = novyBrouk };
        }

    }
}
