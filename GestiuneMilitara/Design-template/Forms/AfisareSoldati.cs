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
           
            int i = 0;
            foreach(Soldati soldatii in soldat)
            {  
                dataGridAfisareSoldati.Rows.Add(new object[] {i,soldatii.Nume, soldatii.Prenume, soldatii.DataNasterii, soldatii.CNP, soldatii.Unitate});
                i++;
            }
            
        }
        private void Afisare_Load(object sender, EventArgs e)
        {
           //de adaugat label pentru cautare soldat si afisarea lui 
            AfiseazaSoldati();
        

        }

        
           
        

       
    }
}
