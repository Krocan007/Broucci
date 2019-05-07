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
            RND = new Random(42);
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
                P.NovyStavKytka = RND.Next(0, VelikostTabulky);
                P.NovyStavPrazdno = RND.Next(0, VelikostTabulky);
                P.NovyStavPrekazka = RND.Next(0, VelikostTabulky);
                P.Kytka = VsechnyAkce[RND.Next(0, VsechnyAkce.Length)];
                P.Prazdno = VsechnyAkce[RND.Next(0, VsechnyAkce.Length)];
                P.Prekazka = VsechnyAkce[RND.Next(0, VsechnyAkce.Length)];
                PolePrikazu[i] = P;
            }
            return new TabulkaPrikazu(PolePrikazu);
        }
    }
}
