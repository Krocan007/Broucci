using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Broucy;
using System.Drawing;

namespace ObrazovkaProBroucky
{
    struct Rozmery
    {
        public int sirka, vyska;
        public Rozmery(int sirka, int vyska)
        {
            this.sirka = sirka;
            this.vyska = vyska;
        }
    }

    struct MapaBrouk
    {
        public Brouk brouk;
        public Mapa mapa;
    }


    class Obrazovka
    {
        public Obrazovka(Panel canvas, MapaBrouk dvojiceMapaBrouk)
        {
            this.mapa = dvojiceMapaBrouk.mapa;
            this.brouk = dvojiceMapaBrouk.brouk;

            this.canvas = canvas;
            predmetyNaMape = new Label[mapa.rozmer, mapa.rozmer];
            deltaX = canvas.Width / mapa.rozmer;
            deltaY = canvas.Height / mapa.rozmer;

            NaplnMapu();
        }
        public Rozmery Rozmery { get => new Rozmery(mapa.rozmer, mapa.rozmer); }
        private Panel canvas;
        private Mapa mapa;
        private Label[,] predmetyNaMape;
        private Brouk brouk;

        private int deltaX, deltaY;


        private Color prazdno = Color.White;
        private Color prekazka = Color.Black;
        private Color kytka = Color.Yellow;
        private Color barvaBrouka = Color.Pink;


        private void NaplnMapu()
        {
            for (int i = 0; i < predmetyNaMape.GetLength(0); i++)
                for (int j = 0; j < predmetyNaMape.GetLength(1); j++)
                    predmetyNaMape[i, j] = VyrobLabel(i,j);

            predmetyNaMape[brouk.souradnice.x, brouk.souradnice.y].BackColor = barvaBrouka;

            canvas.Refresh();
        }

        private Label VyrobLabel(int x, int y)
        {
            Label novyLabel = new Label();
            novyLabel.Parent = canvas;
            novyLabel.Location = new Point(deltaX * x, deltaY * y);
            novyLabel.AutoSize = false;
            novyLabel.Size = new Size(deltaX, deltaY);

            switch (mapa[x,y])
            {
                case Mapa.Predmety.Prazdno:
                    novyLabel.BackColor = prazdno;
                    break;
                case Mapa.Predmety.Prekazka:
                    novyLabel.BackColor = prekazka;
                    break;
                case Mapa.Predmety.Kytka:
                    novyLabel.BackColor = kytka;
                    break;
                default:
                    throw new NotImplementedException();
            }

            return novyLabel;
        }

    }
}
