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
        private double drugo_stevilo;
        private double rezultat = 0;
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
            this.prvo_stevilo = double.Parse(this.lblNapis.Text);
            this.rac_operacija = gmb_operacij.Text;
            this.lblNapis.Text = "0";
        }

        private void gmbJeEnako_Click(object sender, EventArgs e)
        {
            double shrani_drugo_stevilo = double.Parse(this.lblNapis.Text);
            
            
            this.drugo_stevilo = double.Parse(this.lblNapis.Text);

            if (this.rac_operacija != "")
            {
                if (rac_operacija == "+")
                {
                    this.rezultat = this.prvo_stevilo + this.drugo_stevilo;
                }
                else if (this.rac_operacija == "-")
                {
                    this.rezultat = this.prvo_stevilo - this.drugo_stevilo;
                }
                else if (rac_operacija == "*")
                {
                    this.rezultat = this.prvo_stevilo * this.drugo_stevilo;
                }
                else if (rac_operacija == "Mod")
                {
                    this.rezultat = this.prvo_stevilo % this.drugo_stevilo;
                }
                else if (this.rac_operacija == "Log")
                {
                    this.rezultat = Math.Log(this.prvo_stevilo, this.drugo_stevilo);
                }
                else
                {
                    this.rezultat = this.prvo_stevilo / this.drugo_stevilo;
                }

                if (this.rac_operacija == "/" && this.drugo_stevilo == 0)
                    this.lblNapis.Text = "Z 0 ni mogoče deliti";

                else if (this.rac_operacija == "Log" && this.drugo_stevilo == 0)
                    this.lblNapis.Text = "Stevilo> 0";

                else
                {
                    this.lblNapis.Text = this.rezultat.ToString();
                }

            }
            else
            {
                this.lblNapis.Text = "0";
            }
            this.rac_operacija = "";
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
            if (!this.lblNapis.Text.Contains(","))
                this.lblNapis.Text = this.lblNapis.Text + ",";
        }
    }
}
