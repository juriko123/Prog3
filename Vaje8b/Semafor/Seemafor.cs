using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafor
{
    public partial class Seemafor: Form
    {
        private Dictionary<Button, Color> slovar;
        public Seemafor()
        {
            InitializeComponent();
            slovar = new Dictionary<Button, Color> 
            {
                { gmbRdeca, Color.Red},
                { gmbZelena, Color.Green},
                { gmbRumena, Color.Yellow}
            }; 
        }
        /// <summary>
        /// pomagamo si z slovarjem, v katerem so kljuci imena gumbov, in vredsnoti barve
        /// ko pritisnemo na gumb se obarva napis v drugacno barvo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vsi_gumbi_MOUSEDOWN(object sender, MouseEventArgs e)
        {
            Button gumb = (Button)sender;

            if (slovar.ContainsKey(gumb))
                this.lblBarva.BackColor = slovar[gumb];
        }

        private void Vsigumbi_MouseUp(object sender, MouseEventArgs e)
        {
            this.lblBarva.BackColor = Color.White;
        }
    }
}
