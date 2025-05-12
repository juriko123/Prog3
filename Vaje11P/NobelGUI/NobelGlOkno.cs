using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NobelGUI
{
    public partial class NobelGlOkno : Form
    {
        private List<String> podrocja = new List<string>();
        private List<CheckBox> vsiCheckboxi = new List<CheckBox>();
        public NobelGlOkno()
        {
            InitializeComponent();

            PoizvedbaZaPodrocja();
            CheckBoxGumbi();
        }

        /// <summary>
        /// metoda preveri če niz vsebuje same številke
        /// </summary>
        /// <param name="niz"></param>
        /// <returns> vrne true ali false, glede na to ali niz vsebuje same šteivlke ali ne </returns>
        public bool JeStevilka(string niz)
        {
            foreach (char znak in niz)
            {
                if (znak < '0' || znak > '9')
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Metoda, ki dobi podatke iz baze, in jih prilepi na Boxizpis
        /// </summary>
        public void PoizvedbaIzpis()
        {
            string preberi;
            string leto = BoxLeta.Text;

            //pregleda kateri checkboxi so bili obkljukani in jih doda v novo tabelo
            List<string> obkljukani = new List<string>();
            foreach (CheckBox checkbox in vsiCheckboxi)
            {
                if (checkbox.Checked)
                {
                    obkljukani.Add($"'{checkbox.Text.Replace("'", "''")}'");
                }
            }

            //pregleda ali število, ki smo ga vpisali je stevilka ali ne 
            if (!JeStevilka(leto))
            {
                MessageBox.Show("Leto mora biti številka");
                return;
            }

            //Pregleda ali je niz, ki ga vpišemo v textbox prazen ali ne (verjetno ne najboljsi nacin izdelave tega)
            if (string.IsNullOrEmpty(leto))
            {
                if (obkljukani.Count == 0)
                {
                    preberi = "SELECT * FROM nobel";
                }
                else
                {
                    string zdruzi = string.Join(",", obkljukani);
                    preberi = $"SELECT * FROM nobel WHERE subject In ({zdruzi})";
                }
            }

            else
            {
                if (obkljukani.Count == 0)
                {
                    preberi = $"SELECT * FROM nobel WHERE yr = {leto}";
                }
                else
                {
                    string zdruzi = string.Join(",", obkljukani);
                    preberi = $"SELECT * FROM nobel WHERE subject In ({zdruzi}) and yr = {leto}";
                }
            }


            string povNiz = @"Data Source=C:\Users\Jurij\Desktop\Vaje11\nobel.db; Version=3;";
            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            povezava.Open();
            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.CommandType = CommandType.Text;
            ukaz.Connection = povezava;
            ukaz.CommandText = preberi;

            SQLiteDataReader rez = ukaz.ExecuteReader();
            while (rez.Read())
            {
                BoxIzpis.AppendText(rez["yr"].ToString() + " -> " + rez["winner"].ToString() + " : " + rez["subject"].ToString());
                BoxIzpis.AppendText(Environment.NewLine);
            }
            povezava.Close();
        }



        /// <summary>
        /// metoda, sprejme iz baze unikatna podrocja in jih doda v tabelo
        /// </summary>
        public void PoizvedbaZaPodrocja()
        {

            string povNiz = @"Data Source=C:\Users\Jurij\Desktop\Vaje11\nobel.db; Version=3;";
            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            povezava.Open();
            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.CommandType = CommandType.Text;
            ukaz.Connection = povezava;
            string preberi = "SELECT DISTINCT subject FROM nobel";
            ukaz.CommandText = preberi;

            SQLiteDataReader rez = ukaz.ExecuteReader();
            while (rez.Read())
            {
                for (int i = 0; i < rez.VisibleFieldCount; i++)
                {
                    podrocja.Add(rez[i].ToString());
                }
                BoxIzpis.AppendText(Environment.NewLine);
            }
            povezava.Close();
        }

        public void CheckBoxGumbi()
        {
            int y = 10;
            foreach (string podrocje in podrocja)
            {
                CheckBox checkbox = new CheckBox
                {
                    Text = podrocje,
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, y),
                };
                boxPodrocja.Controls.Add(checkbox);
                y += 25;

                vsiCheckboxi.Add(checkbox);
            }
        }

        private void GUMB_Click(object sender, EventArgs e)
        {
            BoxIzpis.Clear();
            PoizvedbaIzpis();
        }
    }
    
}
