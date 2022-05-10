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
        public enum Categorie_armament
        {
            Artilerie = 1,
            Antitanc = 2,
            Antiaerian = 3,
            Infanterie = 4,
            Genistic = 5
        }

        public string CategorieArmament { get; set; } //Armament de infanterie
        public string Model { get; set; }
        public string Tip { get; set; }
        public string Calibru { get; set; }
        public string Detalii { get; set; }
        public string NumarArmament { get; set; }

        /*------------Sfarsit date membre-----------------*/

        /*------------Inceput memode-----------------*/
        public Arme()
        {
            CategorieArmament = string.Empty;
            Model = string.Empty;
            Tip = string.Empty;
            Calibru = string.Empty;
            Detalii = string.Empty;
            NumarArmament = string.Empty;
        }

        public Arme(string _Categorie, string _Model, string _Tip, string _Calibru, string _Detalii, string _NumarArmament)
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
            NumarArmament = Console.ReadLine();
        }

        /*------------Inceput metode GET/SET  -----------------*/


        public string InformatiiArmament()
        {
            return $" Categorie: {CategorieArmament} \n Model: {Model} \n Tip: {Tip} \n Calibru: {Calibru} \n Detalii armament: {Detalii} \n Cantitate: {NumarArmament}";
        }

        public Arme(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            CategorieArmament = dateFisier[CATEGORIE];
            Model = dateFisier[MODEL];
            Tip = dateFisier[TIP];
            Calibru = dateFisier[CALIBRU];
            Detalii = dateFisier[DETALII];
            NumarArmament = dateFisier[NRARMAMENT];
        }

        public string ConversieLaSir_PentruFisier_armament()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}",
                SEPARATOR_PRINCIPAL_FISIER, (CategorieArmament ?? " NECUNOSCUT "), (Model ?? " NECUNOSCUT "), (Tip ?? " NECUNOSCUT "), (Calibru ?? " NECUNOSCUT "), (Detalii ?? " NECUNOSCUT "), (NumarArmament ?? " NECUNOSCUT "));

            return obiectStudentPentruFisier;

            /*------------Sfarsit memode-----------------*/
        }
    }

}


