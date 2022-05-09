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
        private const int Cnp = 2;
        private const int DATA = 3;
        private const int UNITATE = 4;
        public enum Sex
        {
            F=6,
            M=5
        }
       public string Nume { get; set; }
        public string CNP { get; set; }
        public string Prenume { get; set; }
       public string DataNasterii { get; set; }
       public string Unitate { get; set; }


        /*-----------Sfarsit date membre  -----------------*/

        /*------------Inceput memode-----------------*/
        public Soldati()
        {
            Nume = string.Empty;
            Prenume = string.Empty;
            CNP = string.Empty;
            DataNasterii = string.Empty;
            Unitate = string.Empty;
        }

        public Soldati(string _Nume, string _Prenume, string _CNP, string _DataNasterii, string _Unitate)
        {
            Nume = _Nume;
            Prenume = _Prenume;
            CNP = _CNP;
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
            Console.WriteLine("Introduceti CNP-ul:");
            CNP = Console.ReadLine();
            Console.WriteLine("Introduceti data nasterii:");
            DataNasterii = Console.ReadLine();
            Console.WriteLine("Introduceti unitatea din care face parte soldatul:");
            Unitate = Console.ReadLine();
        }

        
       
        public string InformatiiSoldat()
        {
            return $" Nume soldat: {Nume} \n Prenume: {Prenume} \n CNP:{CNP} \n Data nasterii: {DataNasterii} \n Unitate: {Unitate}";
        }

        public string Gen()
        {
            var f = Convert.ToInt32(CNP[1]);
            return ((Sex)f).ToString();

        }

        public Soldati(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
            CNP = dateFisier[Cnp];
            DataNasterii = dateFisier[DATA];
            Unitate = dateFisier[UNITATE];
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR_PRINCIPAL_FISIER, (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "),(CNP ?? "NECUNOSCUT"), (DataNasterii ?? " NECUNOSCUT "), (Unitate ?? " NECUNOSCUT "));

            return obiectStudentPentruFisier;
        }

        /*------------Sfarsit memode-----------------*/
    }
}

