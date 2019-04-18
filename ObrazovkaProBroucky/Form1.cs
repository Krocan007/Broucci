using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObrazovkaProBroucky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            obrazovka = new Obrazovka(pCanvas, TestData.VyrobBroukaSMapou());
        }

        Obrazovka obrazovka;

        private void BStart_Click(object sender, EventArgs e)
        {

        }
    }
}
