using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stevec_klikov
{
    public partial class GlOkno: Form
    {
        private int stevec;
        public GlOkno()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ce kliknoemo na okno povecamo stevec
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlOkno_Click(object sender, EventArgs e)
        {
            stevec++;
            this.lblNapis.Text = "Stevec klikov: " + stevec;
        }
        /// <summary>
        /// ce kliknemo na napis povecamo stevec 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNapis_Click(object sender, EventArgs e)
        {
            stevec++;
            this.lblNapis.Text = "Stevec klikov: " + stevec;
        }
    }
}
