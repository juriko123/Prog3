using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzmenjavaBarv
{
    public partial class IzmenjavaBarvv: Form
    {
        private Random rand = new Random();
        private Color[] barve = {Color.Orange, Color.Violet, Color.Green};
        private int stevec_oranzna = 0;
        private int stevec_vijolicna = 0;
        private int stevec_zelena = 0;
        private bool start = false;
        public IzmenjavaBarvv()
        {
            InitializeComponent();
        }
        /// <summary>
        /// program vsakih 500milisekund spreminja ozadje napisa in drugi napisi prestejejo kolikokrat
        /// se je barva pojavila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameLoop(object sender, EventArgs e)
        {
            int dolzina_seznama = barve.Length;
            if (start)
            {
                Color barva = barve[rand.Next(dolzina_seznama)];
                this.lblBarva.BackColor = barva;

                if (barva == Color.Orange)
                {
                    stevec_oranzna++;
                    this.lblOrange.Text = "Oranžna: " + stevec_oranzna;
                }

                else if (barva == Color.Violet)
                {
                    stevec_vijolicna++;
                    this.lblViola.Text = "Vijolična " + stevec_vijolicna;
                }

                else if (barva == Color.Green)
                {
                    stevec_zelena++;
                    this.lblZelena.Text = "Zelena " + stevec_zelena;
                }
            }
        }
        /// <summary>
        /// ce kliknemo zacni se igra zacne, ce klikenmo ustavi se igra ustavi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gmbzacni_Click(object sender, EventArgs e)
        {
            if (this.gmbzacni.Text == "Zacni")
            {
                start = true;
                this.gmbzacni.Text = "Ustavi";
            }

            else 
            {
                start = false;
                this.gmbzacni.Text = "Zacni";
            }
        }
    }
}
