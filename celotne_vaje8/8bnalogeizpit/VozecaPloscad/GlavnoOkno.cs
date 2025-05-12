using System;
using System.Drawing;
using System.Windows.Forms;

namespace VozecaPloscad
{
    public partial class GlavnoOkno: Form
    {
        private Rectangle kvadrat = new Rectangle(200, 10, 20, 20);
        private int hitrost = 5;
        private int smer = 1;
        private bool start;
        public GlavnoOkno()
        {
            InitializeComponent();
        }

        /// <summary>
        /// narise kvadrat, ter dve premici ki prikazeta kje je koordinatax1 (10) in koordinatax2 (300)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlavnoOkno_Paint(object sender, PaintEventArgs e)
        {
            Graphics platno = e.Graphics;
            Pen svincnik = new Pen(Color.Black);
            
            platno.DrawRectangle(svincnik, kvadrat);
            platno.DrawLine(svincnik, 10, 5, 10, 50);
            platno.DrawLine(svincnik, 300, 5, 300, 50);
        }
        /// <summary>
        /// ob kliku na gumb se kvadrat premika, oz ustavi, odvisno od napisa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gmbGibanje_Click(object sender, EventArgs e)
        {
            if (this.gmbGibanje.Text == "GIBANJE")
            {
                start = true;
                this.gmbGibanje.Text = "USTAVI";
            }
            else
            {
                start = false;
                this.gmbGibanje.Text = "GIBANJE";
            }
                
        }
        /// <summary>
        /// timer, ki se posodablja na usakih 20milisekund
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameLoop(object sender, EventArgs e)
        {
            if (start)

                kvadrat.X += hitrost * smer;

                if (kvadrat.X <= 10 || kvadrat.Right >= 300)
                    smer *= -1;
                

            Invalidate();
        }
    }
}
