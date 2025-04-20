using System;
using System.Drawing;
using System.Windows.Forms;

namespace Druga_Naloga
{
    public partial class GlavOkno: Form
    {
        private int n = 8; // Velikost mreže (n x n)
        private int velikostGumba = 40;
        private int razmik = 10;
        public GlavOkno()
        {
            InitializeComponent();
            NarediMrezo();
            
        }

        private void NarediMrezo()
        {
            int totalWidth = n * (velikostGumba + razmik) + razmik;
            int totalHeight = n * (velikostGumba + razmik) + razmik;

            // Nastavi velikost okna
            this.ClientSize = new Size(totalWidth, totalHeight);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Button gumb = new Button();
                    gumb.Size = new Size(velikostGumba, velikostGumba);
                    gumb.Location = new Point(
                        razmik + j * (velikostGumba + razmik),
                        razmik + i * (velikostGumba + razmik)
                    );
                    gumb.Text = $"{i + 1},{j + 1}";
                    this.Controls.Add(gumb);
                }
            }
        }
    }
}
