using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Broucy;

namespace ObrazovkaProBroucky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Obrazovka obrazovka;
        Mapa mapa;
        Brouk brouk;

        private void BStart_Click(object sender, EventArgs e)
        {
            bRestart.Text = "Restart";

            MapaBrouk mb = TestData.VyrobBroukaSMapou();

            mapa = mb.mapa;
            brouk = mb.brouk;

            if (obrazovka == null)
                obrazovka = new Obrazovka(pCanvas, mb);
            else
                obrazovka.NactiNovouMapuStejneVelikostiABrouka(mb);

            bKrok.Enabled = true;
        }

        private void BKrok_Click(object sender, EventArgs e)
        {
            brouk.UdelejTah();
            obrazovka.ObnovJenomBrouka();
        }
    }
}
