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
        {
            CategorieArmament = Console.ReadLine();
            Model = Console.ReadLine();
            Tip = Console.ReadLine();
            Calibru = Console.ReadLine();
            Detalii = Console.ReadLine();
            NumarArmament = Console.Read();
        }

        /*------------Inceput metode GET  -----------------*/
        public string GetCategorie()
        {
            return CategorieArmament;
        }

        public string GetModel()
        {
            return Model;
        }

        public string GetTip()
        {
            return Tip;
        }

        public string GetCalibru()
        {
            return Calibru;
        }

        public string GetDetalii()
        {
            return Detalii;
        }

        public int GetNumarArmament()
        {
            return NumarArmament;
        }
        /*------------Sfarsit metode GET  -----------------*/

        /*------------Inceput metode SET-----------------*/
        public void SetCategorie(string _Categorie)
        {
            CategorieArmament = _Categorie;
        }

        public void SetModel(string _Model)
        {
            Model = _Model;
        }

        public void SetTip(string _Tip)
        {
            Tip = _Tip;
        }

        public void SetCalibru(string _Calibru)
        {
            Calibru = _Calibru;
        }

        public void SetDetalii(string _Detalii)
        {
            Detalii = _Detalii;
        }

        public void SetNumarArmament(int _NumarArmament)
        {
            NumarArmament = _NumarArmament;
        }
        /*------------Sfarsit metode SET-----------------*/
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

