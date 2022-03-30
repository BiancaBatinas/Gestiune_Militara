using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldat
{
    public class Soldati
    {
        /*------------Inceput date membre  -----------------*/
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int NUME = 0;
        private const int PRENUME = 1;
        private const int DATA = 2;
        private const int UNITATE = 3;

        string Nume;
        string Prenume;
        string DataNasterii;
        string Unitate;
        /*-----------Sfarsit date membre  -----------------*/

        /*------------Inceput memode-----------------*/
        public Soldati()
        {
            Nume = string.Empty;
            Prenume = string.Empty;
            DataNasterii = string.Empty;
            Unitate = string.Empty;
        }

        public Soldati(string _Nume, string _Prenume, string _DataNasterii, string _Unitate)
        {
            Nume = _Nume;
            Prenume = _Prenume;
            DataNasterii = _DataNasterii;
            Unitate = _Unitate;
        }
        /* Laborator 3. Ex 1 Citire*/
        public void Citire_Soldat() //laborator 3 - exercitiul 1
        {
            Console.WriteLine("Introduceti numele:");
            Nume = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele:");
            Prenume = Console.ReadLine();
            Console.WriteLine("Introduceti data nasterii:");
            DataNasterii = Console.ReadLine();
            Console.WriteLine("Introduceti unitatea din care face parte soldatul:");
            Unitate = Console.ReadLine();
        }

        /*------------Inceput metode GET/SET  -----------------*/
        public string NumeSoldat
        {
            get { return Nume; }
            set { Nume = value; }

        }

        public string PrenumeSoldat
        {
            get { return Prenume;  }
            set { Prenume = value; }
        }

        public string DataNasteriiSoldati
        {
            get { return DataNasterii; }
            set { DataNasterii = value; }
        }

        public string UnitateSoldati
        {
            get { return Unitate; }
            set { Unitate = value; }
        }
        /*------------Sfarsit metode GET/SET  -----------------*/
        public string InformatiiSoldat()
        {
            return $" Nume soldat: {NumeSoldat} \n Prenume: {PrenumeSoldat} \n Data nasterii: {DataNasteriiSoldati} \n Unitate: {UnitateSoldati}";
        }

        public Soldati(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
            DataNasterii = dateFisier[DATA];
            Unitate = dateFisier[UNITATE];
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER, (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), (DataNasterii ?? " NECUNOSCUT "), (Unitate ?? " NECUNOSCUT "));

            return obiectStudentPentruFisier;
        }

        /*------------Sfarsit memode-----------------*/
    }
}

