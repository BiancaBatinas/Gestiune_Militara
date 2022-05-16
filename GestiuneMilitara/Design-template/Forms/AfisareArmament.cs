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
            
            int i = 0;
            foreach (Arme armament in arme)
            {

                dataGridAfisareArmament.Rows.Add(new object[] { i, armament.CategorieArmament, armament.Model, armament.Tip, armament.Calibru, armament.Detalii, armament.NumarArmament });
                i++;
            }
        }
        private void AfisareArmament_Load(object sender, EventArgs e)
        {
            
            AfiseazaArmament();
        }

        
    }
}
