using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FilmiGui
{
    public partial class FilmiGlOkno: Form
    {
        public FilmiGlOkno()
        {
            InitializeComponent();

            // doda v comboboxa števila letnic, ki jih lahko uporabimo
            //lahko bi jih dobil iz poizvedb namesto, tako napisal
            for (int i = 1921; i <= 2016; i++)
            {
                comboBox1.Items.Add($"{i}");
                comboBox2.Items.Add($"{i}");
            }
        }

        /// <summary>
        /// metoda, ki naredi poizvedbe in jih izpiše na naš textbox
        /// </summary>
        public void SQL()
        {

            //če ne izberemmo enega od obeh comboboxov pride do napake
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Izberi obe leti.");
                return;
            }

            //če drugi combobox večji od prvega -> od - do 
            if (int.Parse(comboBox1.Text) > int.Parse(comboBox2.Text))
            {
                MessageBox.Show("Prvo leto more biti večje od drugega");
                return;
            }

            string povNiz = @"Data Source=C:\Users\Jurij\Desktop\Vaje11\filmi.sqlite; Version=3;";
            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            povezava.Open();
            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.CommandType = CommandType.Text;
            ukaz.Connection = povezava;
            string poizvedba = $"SELECT naslov, leto, reziser FROM filmi WHERE leto BETWEEN  {comboBox1.Text} and {comboBox2.Text}";
            ukaz.CommandText = poizvedba;

            SQLiteDataReader rez = ukaz.ExecuteReader();
            while (rez.Read())
            {
                for (int i = 0; i < rez.VisibleFieldCount; i++)
                {
                    textBox1.AppendText(rez[i].ToString() + " : ");
                }
                textBox1.AppendText(Environment.NewLine);
            }

            povezava.Close();
        }
        /// <summary>
        /// Metoda, ki sproži druge metode ko pritisnemo na gumb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            SQL();
        }
    }
}
