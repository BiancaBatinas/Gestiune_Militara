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
        private Label lblContext;
        private Label lblNume;
        private Label lblPrenume;
        private Label lblCnp;
        private Label lblCategorie, lblModel, lblTip, lblCalibru, lblDetalii, lblNumarArmament;
        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblscnp;
        private Label[] lblsCategorie, lblsModel, lblsTip, lblsCalibru, lblsDetalii, lblsNumarArmament;
        private const int LATIME_CONTROL = 100;

        private const int DIMENSIUNE_PAS_Y = 50;

        private const int DIMENSIUNE_PAS_X = 100;
        // private Label lblNote;
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
            Arme[] arme = adminArmament.Get_Armament(out int nrArme);

            lblsCategorie = new Label[nrArme];
            lblsModel = new Label[nrArme];
            lblsTip = new Label[nrArme];
             lblsCalibru = new Label[nrArme];
             lblsDetalii = new Label[nrArme];
             lblsNumarArmament = new Label[nrArme];

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

                lblsCalibru[i] = new Label();
                lblsCalibru[i].Width = LATIME_CONTROL;
                lblsCalibru[i].Text = armament.Calibru;
                lblsCalibru[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsCalibru[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCalibru[i]);


                lblsNumarArmament[i] = new Label();
                lblsNumarArmament[i].Width = LATIME_CONTROL;
                lblsNumarArmament[i].Text = armament.Detalii;
                lblsNumarArmament[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsNumarArmament[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNumarArmament[i]);

                lblsDetalii[i] = new Label();
                lblsDetalii[i].Width = LATIME_CONTROL;
                lblsDetalii[i].Text = armament.Detalii;
                lblsDetalii[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblsDetalii[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDetalii[i]);

                i++;
            }
        }
        private void AfisareArmament_Load(object sender, EventArgs e)
        {
            lblContext = new Label();
            lblContext.Width = 400;
            lblContext.Text = "Armament inregistrat";
            lblContext.Left = 120;
            lblContext.AutoSize = false;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            lblContext.Dock = DockStyle.Top;
            lblContext.Top = 10;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblContext);
            AfiseazaArmament();
        }

        
    }
}
