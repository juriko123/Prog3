using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vlak
{
    public partial class Vlak: Form
    {
        private Dictionary<Button, bool> slovar;
        private bool start = false;
        private int stevec;
        public Vlak()
        {
            InitializeComponent();
            slovar = new Dictionary<Button, bool>
            {
                {button1, true},
                {button2, false}
            };
        }
        /// <summary>
        /// na usako 500milisekund spremeni barve napisov, ce start je false spremeni barvo napisov na belo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loop(object sender, EventArgs e)
        {
            if (start)
            {
                if (stevec % 2 == 0)
                {
                    this.label1.BackColor = Color.Red;
                    this.label2.BackColor = Color.White;
                }

                else
                {
                    this.label1.BackColor = Color.White;
                    this.label2.BackColor = Color.Red;
                }

                stevec++; 
            }

            else
            {
                this.label1.BackColor = Color.White;
                this.label2.BackColor = Color.White;
            }
        }
        /// <summary>
        /// s pomocjo slovarja pregleda kateri gumb je bil pritisnjen in odvisno od tega spremeni bool od start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button gumb = (Button)sender;

            if (slovar.ContainsKey(gumb))
                start = slovar[gumb];
                            
        }
    }
}
