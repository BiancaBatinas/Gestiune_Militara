using System.IO;
using Soldat;
using Armament;
using System.Configuration;
using System;

namespace Administrare
{
    public class Administrare_informatii
    {
        private const int NR_MAX_SOLDATI = 100;
        private const int NR_MAX_ARMAMENT = 1000;
        private string numeFisier;


        public Administrare_informatii(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        /*Laborator 3- ex 2 Salvare date in fisier*/
        public void AddSoldat(Soldati soldat)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(soldat.ConversieLaSir_PentruFisier());
            }
        }

        public void AddArmament(Arme arma)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(arma.ConversieLaSir_PentruFisier_armament());
            }
        }

        public Soldati[] GetSoldati(out int nrSoldati)
        {
            Soldati[] soldati = new Soldati[NR_MAX_SOLDATI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrSoldati = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    soldati[nrSoldati++] = new Soldati(linieFisier);
                }
            }

            return soldati;
        }
        public Arme[] Get_Armament(out int nrArmemnt)
        {
            Arme[] arme = new Arme[NR_MAX_ARMAMENT];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrArmemnt = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    arme[nrArmemnt++] = new Arme(linieFisier);
                }
            }

            return arme;
        }
    }
}

