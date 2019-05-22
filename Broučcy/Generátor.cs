using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broucy
{
    public class Generátor
    {
        public Generátor(int n)
        {
            this.VelikostTabulky = n;
            RND = new Random();
            VsechnyAkce = new Akce[]{ Jdi.Instance, OtocDoleva.Instance, OtocDoprava.Instance };
        }
        int VelikostTabulky;
        Random RND;
        Akce[] VsechnyAkce;
        public TabulkaPrikazu VytvorNahodnouTabulku()
        {
            Prikaz[] PolePrikazu= new Prikaz[VelikostTabulky];
            for (int i = 0; i < PolePrikazu.Length; i++)
            {
                Prikaz P = new Prikaz();
                P.NovyStavKytka = RND.Next(0, VelikostTabulky - 1);
                P.NovyStavPrazdno = RND.Next(0, VelikostTabulky - 1);
                P.NovyStavPrekazka = RND.Next(0, VelikostTabulky - 1);
                P.Kytka = VsechnyAkce[RND.Next(0, VsechnyAkce.Length - 1)];
                P.Prazdno = VsechnyAkce[RND.Next(0, VsechnyAkce.Length - 1)];
                P.Prekazka = VsechnyAkce[RND.Next(0, VsechnyAkce.Length - 1)];
                PolePrikazu[i] = P;
            }
            return new TabulkaPrikazu(PolePrikazu);
        }


    }
}
