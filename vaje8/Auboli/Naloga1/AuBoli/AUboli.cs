using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuBoli
{
    public partial class AUboli: Form
    {
        private int zac_stevilo = 10;
        bool start = false;
        public AUboli()
        {
            InitializeComponent();
        }

        private void gmbKlik_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Au, boli....";
            zac_stevilo -= 2;
            start = true;
        }

        private void gmbPomoc_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Ne boli me več, hvala!";
            zac_stevilo += 10;
            start = true;
        }

        private void Odštevaj(object sender, EventArgs e)
        {
            
            if (start)
            {
                this.label2.Text = "Za klikniti imaš na voljo le še: " + zac_stevilo.ToString() + "s";

                if (zac_stevilo < 0)
                {
                    Close();
                }
                zac_stevilo -= 1;
            }
        }
    }
}
