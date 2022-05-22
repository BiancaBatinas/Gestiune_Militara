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
    public partial class AfisareArmament : Form
    {
        Administrare_informatii adminMilitari, adminArmament;
      
        private const int LATIME_CONTROL = 100;

        private const int DIMENSIUNE_PAS_Y = 50;

        private const int DIMENSIUNE_PAS_X = 100;
        Arme[] arme;
        DataTable table;
        int indexRow;
        public AfisareArmament()
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
       

        private void AfiseazaArmament()
        {
            arme = adminArmament.Get_Armament(out int nrArme);

            table = new DataTable();
            int i = 1;

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Categorie", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Tip", typeof(string));
            table.Columns.Add("Calibru", typeof(string));
            table.Columns.Add("Detalii", typeof(string));
            table.Columns.Add("Cantitate", typeof(string));

            foreach (Arme armament in arme)
            {
               
                table.Rows.Add(new object[] { i , armament.CategorieArmament, armament.Model, armament.Tip, armament.Calibru, armament.Detalii, armament.NumarArmament });
                i++;
                dataGridAfisareArmament.DataSource = table;

            }
        }
  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = listBox1.SelectedItem.ToString() + " LIKE '" + textBox1.Text + "%'";
            dataGridAfisareArmament.DataSource = dv;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataGridViewRow newDataRow = dataGridAfisareArmament.Rows[indexRow];
            newDataRow.Cells[0].Value = textID.Text;
            newDataRow.Cells[1].Value = textCategorie.Text;
            newDataRow.Cells[2].Value = textModel.Text;
            newDataRow.Cells[3].Value = textTip.Text;
            newDataRow.Cells[4].Value = textCalibru.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridAfisareArmament_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridAfisareArmament.Rows[e.RowIndex];
                textID.Text = row.Cells[0].Value.ToString();
                textCategorie.Text = row.Cells[1].Value.ToString();
                textModel.Text = row.Cells[2].Value.ToString();
                textTip.Text = row.Cells[3].Value.ToString();
                textCalibru.Text = row.Cells[4].Value.ToString();
            }
        }

            private void timer1_Tick(object sender, EventArgs e)
        {
            if(panelRefresh.Width ==230)
            {
                for(int i=0; i<10; i++)
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

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AfisareArmament_Load(object sender, EventArgs e)
        {
            LoadTheme();
            panelRefresh.Width = 0;
            AfiseazaArmament();
          
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
           panelRefresh.BackColor= CuloriTema.PrimaryColor;
            panelRefreshContinut.BackColor= CuloriTema.PrimaryColor; ;

        }
    }
}
