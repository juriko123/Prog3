using System;
using System.Drawing;
using System.Windows.Forms;

namespace BezeciGumb
{
    public partial class Form1: Form
    {
        private int stevec = 0;
        private bool start = false;
        private int odstevalnik = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void gmbKlikniMe_Click(object sender, EventArgs e)
        {
            if (start)
            {
                stevec++;
            }
        }

        private void Premiki(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (start)
                this.gmbKlikniMe.Location = new Point(rand.Next(this.ClientSize.Width - 100),rand.Next(this.ClientSize.Height - 100));
        }

        private void StartIgre()
        {
            start = true;
            stevec = 0;
            odstevalnik = 10;
            lblCas.Text = $"Čas: {odstevalnik}";

            Igra.Start();
        }

        private void Start_game_Click(object sender, EventArgs e)
        {
            StartIgre();
            gmbStart.Visible = false;
        }

        private void ZačetekIgre(object sender, EventArgs e)
        {
            if (!start) return;

            odstevalnik--;
            lblCas.Text = $"Čas: {odstevalnik}";

            if (odstevalnik <= 0)
            {
                Igra.Stop();
                start = false;

                MessageBox.Show($"Konec igre, število klikov: {stevec}");

                gmbSeenkrat.Visible = true;
            }
        }

        private void gmbSeenkrat_Click(object sender, EventArgs e)
        {
            StartIgre();
            this.gmbSeenkrat.Visible = false;
        }
    }
}
