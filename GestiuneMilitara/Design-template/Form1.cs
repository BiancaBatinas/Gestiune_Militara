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


namespace Design_template
{
    public partial class Form1 : Form
    {
        Administrare_informatii adminMilitari, adminArmament;

        private Label lblContext;
        private Label lblNume;
        private Label lblPrenume;
        private Label lblCnp;
        private Label lblCategorie, lblModel, lblTip, lblCalibru, lblDetalii, lblNumarArmament;
       // private Label lblNote;

        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblscnp;
        private Label[] lblsCategorie, lblsModel, lblsTip, lblsCalibru, lblsDetalii, lblsNumarArmament;

      



        // private Label[] lblsNote;

        private const int LATIME_CONTROL = 100;

        private const int DIMENSIUNE_PAS_Y = 50;

        private const int DIMENSIUNE_PAS_X = 120;

        public Form1()
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

            //setare proprietati
            this.Size = new Size(500, 200);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 10, FontStyle.Bold);
            this.ForeColor = Color.CornflowerBlue;
            this.Text = "Informatii ";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void AfiseazaSoldati()
        {
            Soldati[] soldat = adminMilitari.GetSoldati(out int nrSoldati);

            lblsNume = new Label[nrSoldati];
            lblsPrenume = new Label[nrSoldati];
            lblscnp = new Label[nrSoldati];

            int i = 0;
            foreach (Soldati soldatii in soldat)
            {
                //adaugare control de tip Label pentru numele studentilor;
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = soldatii.Nume;
                lblsNume[i].Left = DIMENSIUNE_PAS_X;
                lblsNume[i].Top = (i+1)* DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                //adaugare control de tip Label pentru prenumele studentilor
                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = soldatii.Prenume;
                lblsPrenume[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsPrenume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[i]);

                //adaugare control de tip Label pentru cnp studentilor
                lblscnp[i] = new Label();
                lblscnp[i].Width = LATIME_CONTROL;
                lblscnp[i].Text = soldatii.CNP;
                lblscnp[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblscnp[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblscnp[i]);
                i++;
            }
        }

        private void AfiseazaArmament()
        {
            Arme[] arme = adminArmament.Get_Armament(out int nrArme);

            lblsCategorie = new Label[nrArme];
            lblsModel = new Label[nrArme];
            lblsTip = new Label[nrArme];
           // lblsCalibru = new Label[nrArme];
           // lblsDetalii = new Label[nrArme];
           // lblsNumarArmament = new Label[nrArme];

            int i = 0;
            foreach (Arme armament in arme)
            {

                //adaugare control de tip Label pentru numele studentilor;
                lblsCategorie[i] = new Label();
                lblsCategorie[i].Width = LATIME_CONTROL;
                lblsCategorie[i].Text = armament.CategorieArmament;
                lblsCategorie[i].Left = DIMENSIUNE_PAS_X;
                lblsCategorie[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCategorie[i]);
                //adaugare control de tip Label pentru prenumele studentilor
                lblsModel[i] = new Label();
                lblsModel[i].Width = LATIME_CONTROL;
                lblsModel[i].Text = armament.Model;
                lblsModel[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsModel[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsModel[i]);

                //adaugare control de tip Label pentru cnp studentilor
                lblsTip[i] = new Label();
                lblsTip[i].Width = LATIME_CONTROL;
                lblsTip[i].Text = armament.Tip;
                lblsTip[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsTip[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsTip[i]);
                i++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void armamentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            //adaugare control de tip Label pentru 'Context';
            lblContext = new Label();
            lblContext.Width = 400;
            lblContext.Text = "Arme inregistrate";
            lblContext.Left = 120;
            lblContext.Top = 25;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            lblContext.BackColor = Color.LightSkyBlue;
            lblContext.ForeColor = Color.CornflowerBlue;
            this.Controls.Add(lblContext);
            //adaugare control de tip Label pentru 'Nume';
            lblCategorie = new Label();
            lblCategorie.Width = LATIME_CONTROL;
            lblCategorie.Text = "Categorie";
            lblCategorie.Left = DIMENSIUNE_PAS_X;
            lblCategorie.Top = 50;
            lblCategorie.BackColor = Color.LightSkyBlue;
            lblCategorie.ForeColor = Color.DarkSlateBlue;
            this.Controls.Add(lblCategorie);

            //adaugare control de tip Label pentru 'Prenume';
            lblModel = new Label();
            lblModel.Width = LATIME_CONTROL;
            lblModel.Text = "Model";
            lblModel.Left = 2 * DIMENSIUNE_PAS_X;
            lblModel.Top = 50;
            lblModel.BackColor = Color.LightSkyBlue;
            lblModel.ForeColor = Color.DarkSlateBlue;
            this.Controls.Add(lblModel);

            //adaugare control de tip Label pentru 'CNP';
            lblTip = new Label();
            lblTip.Width = LATIME_CONTROL;
            lblTip.Text = "Tip";
            lblTip.Left = 3 * DIMENSIUNE_PAS_X;
            lblTip.Top = 50;
            lblTip.BackColor = Color.LightSkyBlue;
            lblTip.ForeColor = Color.DarkSlateBlue;
            this.Controls.Add(lblTip);
            AfiseazaArmament();

        }

        private void soldatiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //adaugare control de tip Label pentru 'Context';
            lblContext = new Label();
            lblContext.Width = 400;
            lblContext.Text = "Soldati inregistrati";
            lblContext.Left = 120;
            lblContext.Top = 25;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            lblContext.BackColor = Color.LightSkyBlue;
            lblContext.ForeColor = Color.CornflowerBlue;
            this.Controls.Add(lblContext);
            //adaugare control de tip Label pentru 'Nume';
            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume";
            lblNume.Left = DIMENSIUNE_PAS_X;
            lblNume.Top = 50;
            lblNume.BackColor = Color.LightSkyBlue;
            lblNume.ForeColor = Color.DarkSlateBlue;
            this.Controls.Add(lblNume);

            //adaugare control de tip Label pentru 'Prenume';
            lblPrenume = new Label();
            lblPrenume.Width = LATIME_CONTROL;
            lblPrenume.Text = "Prenume";
            lblPrenume.Left = 2 * DIMENSIUNE_PAS_X;
            lblPrenume.Top = 50;
            lblPrenume.BackColor = Color.LightSkyBlue;
            lblPrenume.ForeColor = Color.DarkSlateBlue;
            this.Controls.Add(lblPrenume);

            //adaugare control de tip Label pentru 'CNP';
            lblCnp = new Label();
            lblCnp.Width = LATIME_CONTROL;
            lblCnp.Text = "CNP";
            lblCnp.Left = 3 * DIMENSIUNE_PAS_X;
            lblCnp.Top = 50;
            lblCnp.BackColor = Color.LightSkyBlue;
            lblCnp.ForeColor = Color.DarkSlateBlue;
            this.Controls.Add(lblCnp);
            AfiseazaSoldati();
        }


    }
}
