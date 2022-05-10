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
using System.Text.RegularExpressions;

namespace Design_template.Forms
{
    public partial class InregistrareArme : Form
    {

        bool compara = false;
        int marime = 0;
        Administrare_informatii adminMilitari, adminArmament;

        int nrSoldati = 0;
        int nrArmament = 0;
        Soldati soldat = new Soldati();
        Arme Arme = new Arme();
        
        public InregistrareArme()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            string _numeFisier = ConfigurationManager.AppSettings["_NumeFisier"];
            string locatieFisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier_arme = locatieFisierSolutie1 + "\\" + _numeFisier;
            adminArmament = new Administrare_informatii(caleCompletaFisier_arme);

            adminMilitari = new Administrare_informatii(caleCompletaFisier);

            adminArmament.Get_Armament(out nrArmament);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ok = 1;
            if (compara == false)
            {
                button1.Width = 2 * button1.Width;
                compara = true;
            }
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0 && textBox6.Text.Length != 0)
            {


                if (textBox1.Text.Any(c=> char.IsDigit(c)))
                {
                    textBox1.BackColor = Color.FromArgb(250, 220, 217);
                    ok = 0;
                }
                if (textBox2.Text.Any(c => char.IsDigit(c)))
                {
                    textBox2.BackColor = Color.FromArgb(250, 220, 217);
                    ok = 0;
                }
                if (textBox3.Text.Any(c => char.IsDigit(c)))
                {
                    textBox3.BackColor = Color.FromArgb(250, 220, 217);
                    ok = 0;
                }

                if (textBox4.Text.Any(c => char.IsDigit(c)))
                {
                    textBox4.BackColor = Color.FromArgb(250, 220, 217);
                    ok = 0;
                }

                if (textBox5.Text.Any(c => char.IsDigit(c)))
                {
                    textBox5.BackColor = Color.FromArgb(250, 220, 217);
                    ok = 0;
                }

                if (!int.TryParse(textBox6.Text, out _))
                {
                    textBox6.BackColor = Color.FromArgb(250, 220, 217);
                    ok = 0;
                }

                if (ok==1)
                {
                    button1.Text = "S-a trimis.";
                    button1.BackColor = Color.White;
                    nrArmament = nrArmament + 1;
                    Arme = new Arme(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                    adminArmament.AddArmament(Arme);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
               if(ok==0)
                {
                    button1.Text = "Datele nu sunt valide!";
                    button1.BackColor = Color.FromArgb(250, 220, 217);
                }


            }
            else
            {
                button1.Text = "Completati toate datele!";
                button1.BackColor = Color.FromArgb(250, 220, 217);
                if (textBox1.Text.Length == 0)
                    textBox1.BackColor = Color.FromArgb(250, 220, 217);

                if (textBox2.Text.Length == 0)
                    textBox2.BackColor = Color.FromArgb(250, 220, 217);

                if (textBox3.Text.Length == 0)
                    textBox3.BackColor = Color.FromArgb(250, 220, 217);
                if (textBox4.Text.Length == 0)
                    textBox4.BackColor = Color.FromArgb(250, 220, 217);
                if (textBox5.Text.Length == 0)
                    textBox5.BackColor = Color.FromArgb(250, 220, 217);

                if (textBox6.Text.Length == 0)
                    textBox6.BackColor = Color.FromArgb(250, 220, 217);

            }


            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                textBox1.BackColor = Color.White;
            else
                textBox1.BackColor = Color.AliceBlue;
        }
    

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
            if (textBox2.Text.Length != 0)
                textBox2.BackColor = Color.White;
            else
                textBox2.BackColor = Color.AliceBlue;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 0)
                textBox3.BackColor = Color.White;
            else
                textBox3.BackColor = Color.AliceBlue;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length != 0)
                textBox4.BackColor = Color.White;
            else
                textBox4.BackColor = Color.AliceBlue;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length != 0)
                textBox5.BackColor = Color.White;
            else
                textBox5.BackColor = Color.AliceBlue;
        }

        private void InregistrareArme_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length != 0)
                textBox6.BackColor = Color.White;
            else
                textBox6.BackColor = Color.AliceBlue;
        }
    }
}
