using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeviInDesni
{
    public partial class LeviNDesni: Form
    {
        public LeviNDesni()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ko pritisnemo in drzimo z misko katerega koli od gumbov se pojavi na label nek napis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Oba_MouseDown(object sender, MouseEventArgs e)
        {
            Button gumb = (Button)sender;
            if (gumb == gmbLevi)
                this.lblNapis.Text = "<- pritisnjen";
            else
                this.lblNapis.Text = "pritisnjen ->";
        }
        /// <summary>
        /// ko misko izpustimo se napis pobrise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Oba_MouseUp(object sender, MouseEventArgs e)
        {
            this.lblNapis.Text = "";
        }
    }
}
