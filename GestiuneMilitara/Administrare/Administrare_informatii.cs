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
        /*Laborator 3. Cautare dupa criterii*/
        public Soldati Cautare_in_fisier(string cautare_string)
        {
            //Soldati[] soldati = new Soldati[NR_MAX_SOLDATI];
            Soldati _soldat = new Soldati();
            bool semafor = false;
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier; 
                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null && semafor==false)
                {
                    if(linieFisier.IndexOf(cautare_string)!=-1)
                    {
                        _soldat = new Soldati(linieFisier);
                        semafor = true;
                    }
                   
                }
            }
            return _soldat;
        }

        /*Laborator 3. Cautare dupa criterii----------------------------------------------------------------------------------------*/
        public Arme Cautare_in_fisier_arme(string cautare_string)
        {
            //Soldati[] soldati = new Soldati[NR_MAX_SOLDATI];
            Arme _arme = new Arme();
            bool semafor = false;
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null && semafor == false)
                {
                    if (linieFisier.IndexOf(cautare_string) != -1)  // trebuie adaugata o conditie care sa verifice  daca este un cuvant nu doar o parte din el
                    {
                        _arme = new Arme(linieFisier);
                        semafor = true;
                    }

                }
            }
            return _arme;
        }


        public Soldati[] GetSoldati(out int nrSoldati)
        {
            Soldati[] soldati = new Soldati[NR_MAX_SOLDATI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier; //bianca;ioana;
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

