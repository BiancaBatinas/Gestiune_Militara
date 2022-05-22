using Administrare;
using Armament;
using Soldat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Design_template.Forms
{
    public partial class AfisareSoldati : Form
    {
        Administrare_informatii adminMilitari, adminArmament;
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Afisare_Resize(object sender, EventArgs e)
        {
            
        }

        private const int LATIME_CONTROL = 100;

        private const int DIMENSIUNE_PAS_Y = 50;

        private const int DIMENSIUNE_PAS_X = 100;

        DataTable table;
        Soldati[] soldat;
        int indexRow;
        public AfisareSoldati()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            string _numeFisier = ConfigurationManager.AppSettings["_NumeFisier"];
            string locatieFisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier_arme = locatieFisierSolutie1 + "\\" + _numeFisier;
            adminArmament = new Administrare_informatii(caleCompletaFisier_arme);

            adminMilitari = new Administrare_informatii(caleCompletaFisier);
            InitializeComponent();
           
        }
        private void AfiseazaSoldati()
        {
           soldat = adminMilitari.GetSoldati(out int nrSoldati);
            table = new DataTable();
            int i = 1;
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nume", typeof(string));
            table.Columns.Add("Prenume", typeof(string));
            table.Columns.Add("Data Nasterii", typeof(string));
            table.Columns.Add("CNP", typeof(string));
            table.Columns.Add("Unitate", typeof(string));
           
            foreach (Soldati soldatii in soldat)
            {
                table.Rows.Add(new object[] {i,soldatii.Nume, soldatii.Prenume, soldatii.DataNasterii, soldatii.CNP, soldatii.Unitate});
                i++;
                dataGridAfisareSoldati.DataSource = table;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = listBox1.SelectedItem.ToString() + " LIKE '" + textBox1.Text + "%'";
            dataGridAfisareSoldati.DataSource = dv;
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelRefresh.Width == 230)
            {
                for (int i = 0; i < 10; i++)
                {
                    panelRefresh.Width = panelRefresh.Width - 23;
                }
            }
            else
            {

                for (int i = 0; i < 10; i++)
                {
                    panelRefresh.Width = panelRefresh.Width + 23;
                }
            }
            timer1.Stop();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            
        }
        private void dataGridAfisareSoldati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridAfisareSoldati.Rows[e.RowIndex];
                textID.Text = row.Cells[0].Value.ToString();
                textNume.Text = row.Cells[1].Value.ToString();
                textPrenume.Text = row.Cells[2].Value.ToString();
                textData.Text = row.Cells[3].Value.ToString();
                textUnitate.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Afisare_Load(object sender, EventArgs e)
        {
            LoadTheme();
            panelRefresh.Width = 0;
            AfiseazaSoldati();
        

        }

        private void Update_gridCell_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridAfisareSoldati.Rows[indexRow];
            newDataRow.Cells[0].Value = textID.Text;
            newDataRow.Cells[1].Value = textNume.Text;
            newDataRow.Cells[2].Value = textPrenume.Text;
            newDataRow.Cells[3].Value = textData.Text;
            newDataRow.Cells[4].Value = textUnitate.Text;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = CuloriTema.PrimaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = CuloriTema.SecondaryColor;
                }
            }
            panel2.BackColor = CuloriTema.PrimaryColor;
            panelRefresh.BackColor = CuloriTema.PrimaryColor;
            panelRefreshContinut.BackColor = CuloriTema.PrimaryColor; ;

        }





    }
}
