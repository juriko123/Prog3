using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator: Form
    {
        private double prvo_stevilo = 0;
        private string rac_operacija = "";
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Števila_Click(object sender, EventArgs e)
        {
            Button gmb_stevil = (Button)sender;
            if (this.lblNapis.Text == "0")
                this.lblNapis.Text = gmb_stevil.Text;
            else
                this.lblNapis.Text += gmb_stevil.Text;
        }

        private void Rac_Operacije_Click(object sender, EventArgs e)
        {
            Button gmb_operacij = (Button)sender;
            prvo_stevilo = double.Parse(this.lblNapis.Text);
            this.rac_operacija = gmb_operacij.Text;
            this.lblNapis.Text = "0";
        }

        private void gmbJeEnako_Click(object sender, EventArgs e)
        {
            double drugo_stevilo;
            double rezultat = 0;

            if (rac_operacija != "")
            {
                drugo_stevilo = double.Parse(this.lblNapis.Text);
                if (rac_operacija == "+")
                {
                    rezultat = prvo_stevilo + drugo_stevilo;
                }
                else if (rac_operacija == "-")
                {
                    rezultat = prvo_stevilo - drugo_stevilo;
                }
                else if (rac_operacija == "*")
                {
                    rezultat = prvo_stevilo * drugo_stevilo;
                }
                else if (rac_operacija == "mod")
                {
                    rezultat = prvo_stevilo % drugo_stevilo;
                }
                else if (rac_operacija == "Log")
                {
                    rezultat = Math.Log(prvo_stevilo, drugo_stevilo);
                }
                else
                {
                    rezultat = prvo_stevilo / drugo_stevilo;
                }

                if (rac_operacija == "/" && drugo_stevilo == 0)
                    this.lblNapis.Text = "Z 0 ni mogoče deliti";
                
                else
                    this.lblNapis.Text = rezultat.ToString();

            }
            else
                this.lblNapis.Text = "0";
        }

        private void gmbClear_Click(object sender, EventArgs e)
        {
            this.lblNapis.Text = "0";
            this.prvo_stevilo = 0;
            this.rac_operacija = "";
        }

        private void gmbPocististevilko_Click(object sender, EventArgs e)
        {
            int odrezi = int.Parse(this.lblNapis.Text) / 10;
            this.lblNapis.Text = odrezi.ToString();
        }

        private void gmbDecimalna_vejica_Click(object sender, EventArgs e)
        {
            this.lblNapis.Text = this.lblNapis.Text + ",";
        }
    }
}
