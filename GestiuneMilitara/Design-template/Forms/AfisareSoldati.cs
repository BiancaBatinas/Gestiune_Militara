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
        private Label lblContext;
        private Label lblNume;
        private Label lblPrenume;
        private Label lblCnp, lblData;
        private Label lblCategorie, lblModel, lblTip, lblCalibru, lblDetalii, lblNumarArmament;
        // private Label lblNote;

        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblscnp, lblsData, lblsUnit;

        private void Afisare_Resize(object sender, EventArgs e)
        {
            
        }

        private Label[] lblsCategorie, lblsModel, lblsTip, lblsCalibru, lblsDetalii, lblsNumarArmament;
        private const int LATIME_CONTROL = 100;

        private const int DIMENSIUNE_PAS_Y = 50;

        private const int DIMENSIUNE_PAS_X = 100;

       
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
            Soldati[] soldat = adminMilitari.GetSoldati(out int nrSoldati);

            lblsNume = new Label[nrSoldati];
            lblsPrenume = new Label[nrSoldati];
            lblscnp = new Label[nrSoldati];
            lblsData = new Label[nrSoldati];
            lblsUnit = new Label[nrSoldati];

            int i = 0;
            foreach (Soldati soldatii in soldat)
            {
                //adaugare control de tip Label pentru numele studentilor;
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = soldatii.Nume;
                lblsNume[i].Left = DIMENSIUNE_PAS_X;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
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

                lblsData[i] = new Label();
                lblsData[i].Width = LATIME_CONTROL;
                lblsData[i].Text = soldatii.DataNasterii;
                lblsData[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsData[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsData[i]);

                lblsUnit[i] = new Label();
                lblsUnit[i].Width = LATIME_CONTROL;
                lblsUnit[i].Text = soldatii.Unitate;
                lblsUnit[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsUnit[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsUnit[i]);


                i++;
            }
        }
        private void Afisare_Load(object sender, EventArgs e)
        {
           
            lblContext = new Label();
            lblContext.Width = 400;
            lblContext.Text = "Soldati inregistrati";
            lblContext.Left = 120;
            lblContext.Top = 10;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            lblContext.AutoSize = false;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            lblContext.Dock = DockStyle.Top;
            lblContext.Top = 10;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblContext);
            AfiseazaSoldati();
         



        }

        
           
        

       
    }
}
