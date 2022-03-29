using System;

namespace Armament
{
    public class Arme
    {
        /*------------Date membre-----------------*/
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int CATEGORIE = 0;
        private const int MODEL = 1;
        private const int TIP = 2;
        private const int CALIBRU = 3;
        private const int DETALII = 4;
        private const int NRARMAMENT = 5;

        string CategorieArmament; //Armament de infanterie
        string Model; //ZU-2
        string Tip;//Mitralieră antiaeriană
        string Calibru;//2×14,5mm
        string Detalii;//Versiune de producție românească.
        int NumarArmament;//1000
        /*------------Sfarsit date membre-----------------*/

        /*------------Inceput memode-----------------*/
        public Arme()
        {
            CategorieArmament = string.Empty;
            Model = string.Empty;
            Tip = string.Empty;
            Calibru = string.Empty;
            Detalii = string.Empty;
            NumarArmament = 0;
        }

        public Arme(string _Categorie, string _Model, string _Tip, string _Calibru, string _Detalii, int _NumarArmament)
        {
            CategorieArmament = _Categorie;
            Model = _Model;
            Tip = _Tip;
            Calibru = _Calibru;
            Detalii = _Detalii;
            NumarArmament = _NumarArmament;
        }

        public void Citire_Armament()
        {   /* Pentru categoria de arme se poate face o enumeratie din cate sa aleaga dintre cele 8-9 variante. 
             Se inlocuieste citirea categoriei*/
            Console.WriteLine("Introduceti categoria:");
            CategorieArmament = Console.ReadLine();
            Console.WriteLine("Introduceti modelul:");
            Model = Console.ReadLine();
            Console.WriteLine("Introduceti tipul:");
            Tip = Console.ReadLine();
            Console.WriteLine("Introduceti calibrul:");
            Calibru = Console.ReadLine();
            Console.WriteLine("Introduceti detalii:");
            Detalii = Console.ReadLine();
            Console.WriteLine("Introduceti cantitatea:");
            NumarArmament = Console.Read();
        }

        /*------------Inceput metode GET/SET  -----------------*/
        /*Laborator 5 -Implementari automate*/
        public string Categorie
        {
            get { return CategorieArmament; }
            set { CategorieArmament = value; }
            
        }

        public string Model_arma
        {
            get { return Model; }
            set { Model = value; }
        }

        public string TipArma
        {
            get { return Tip; }
            set { Tip = value; }
        }

        public string CalibruArma
        {
            get { return Calibru; }
            set { Calibru = value; }
        }

        public string DetaliiArma
        {
            get { return Detalii; }
            set { Detalii = value; }
        }

        public int NumarArme
        {
            get { return NumarArmament; }
            set { NumarArmament = value; }
        }
        /*------------Sfarsit metode GET/SET  -----------------*/

        public string InformatiiArmament()
        {
            return $" Categorie: {Categorie} \n Model: {Model_arma} \n Tip: {TipArma} \n Calibru: {CalibruArma} \n Detalii armament: {DetaliiArma} \n Cantitate: {NumarArme}";
        }

        public Arme(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            CategorieArmament = dateFisier[CATEGORIE];
            Model = dateFisier[MODEL];
            Tip = dateFisier[TIP];
            Calibru = dateFisier[CALIBRU];
            Detalii = dateFisier[DETALII];
            NumarArmament = Convert.ToInt32(dateFisier[NRARMAMENT]);
        }

        public string ConversieLaSir_PentruFisier_armament()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}",
                SEPARATOR_PRINCIPAL_FISIER, (CategorieArmament ?? " NECUNOSCUT "), (Model ?? " NECUNOSCUT "), (Tip ?? " NECUNOSCUT "), (Calibru ?? " NECUNOSCUT "), (Detalii ?? " NECUNOSCUT "), NumarArmament.ToString());

            return obiectStudentPentruFisier;
        }
        /*------------Sfarsit memode-----------------*/
    }
}


