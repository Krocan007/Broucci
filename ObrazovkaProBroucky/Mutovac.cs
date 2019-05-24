using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broucy
{
    //Zmutuje jeden řádek tabulky příkazů
    //Potřebuje jako argument Pole Příkazů - získat od předchozí tabulky
    class Mutovac
    {
        public Mutovac(Prikaz[] PolePrikazu,int n)
        {
            RND = new Random(69);
            VsechnyAkce = new Akce[] { Jdi.Instance, OtocDoleva.Instance, OtocDoprava.Instance };
            this.PolePrikazu = PolePrikazu;
            VelikostTabulky = n;
            KterejPrikaz = RND.Next(1, 6);
        }
        Random RND;
        Akce[] VsechnyAkce;
        int KterejPrikaz;
        Prikaz[] PolePrikazu;
        int VelikostTabulky;

        public TabulkaPrikazu ZmutujTabulku(int KterejPrikaz, Prikaz[] PolePrikazu)
        {
            KterejPrikaz = RND.Next(0, 5);
            Prikaz P = new Prikaz();
            P.NovyStavKytka = RND.Next(0, VelikostTabulky - 1);
            P.NovyStavPrazdno = RND.Next(0, VelikostTabulky - 1);
            P.NovyStavPrekazka = RND.Next(0, VelikostTabulky - 1);
            P.Kytka = VsechnyAkce[RND.Next(0, VsechnyAkce.Length - 1)];
            P.Prazdno = VsechnyAkce[RND.Next(0, VsechnyAkce.Length - 1)];
            P.Prekazka = VsechnyAkce[RND.Next(0, VsechnyAkce.Length - 1)];
            PolePrikazu[KterejPrikaz] = P;
            return new TabulkaPrikazu(PolePrikazu);
        }
    }
}
