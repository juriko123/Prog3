using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Prva_naloga
{
    public partial class tbGeslo: Form
    {
        public tbGeslo()
        {
            InitializeComponent();
        }

        private string PravilnoGeslo(string geslo)
        {
            List<string> napake = new List<string>();

            if (string.IsNullOrWhiteSpace(geslo))
            {
                napake.Add("- Geslo ne sme biti prazno.");
                return string.Join("", napake);
            }

            if (!char.IsUpper(geslo[0]))
                napake.Add("- Prva črka mora biti velika začetnica.");

            if (!geslo.Any(char.IsDigit))
                napake.Add("- Geslo mora vsebovati vsaj eno številko.");

            if (!geslo.Contains('.'))
                napake.Add("- Geslo mora vsebovati vsaj eno piko (.)");

            return string.Join(" ", napake);
        }

        private bool JeGesloVeljavno(string geslo)
        {
            if (string.IsNullOrWhiteSpace(geslo)) return false;

            bool prvaCrkaVelika = char.IsUpper(geslo[0]);

            bool imaStevko = geslo.Any(char.IsDigit);

            bool imaPiko = geslo.Contains('.');

            return prvaCrkaVelika && imaStevko && imaPiko;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string geslo = this.textBox1.Text;
            string napake = PravilnoGeslo(geslo);

            if (JeGesloVeljavno(geslo))
            {
                this.label1.Text = "Geslo je veljavno!";
            }
            else
            {
                this.label1.Text = $"Neveljavno geslo:\n {napake}";
            }
        }
    }
}
