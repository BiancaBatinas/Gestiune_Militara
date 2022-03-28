﻿
using System;
using System.Configuration;
using Armament;
using Soldat;
using Administrare;
using System.Linq;

namespace GestiuneMilitara
{
    class Program
    {
        static void Main(string[]  args)
        {

            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            else
            {

                // afisarea numarului de argumente
                Console.WriteLine("Numarul de argumente este: {0}", args.Length);
                // afisarea argumentelor liniei de comanda
                foreach (string param in args)
                    Console.WriteLine(param);

                string[][] tablou_argumente = new string[3][];
                tablou_argumente[0] = new string[1];
                tablou_argumente[1] = new string[3];
                tablou_argumente[3] = new string[4];

                for(int i=0; i<tablou_argumente.Length; i++)
                {
                    for(int j=0; j<tablou_argumente[i].Length; j++)
                    {
                        tablou_argumente[i][j] = args[0].ToString();
                    }
                }

                for (int i = 0; i < tablou_argumente.Length; i++)
                {
                    for (int j = 0; j < tablou_argumente[i].Length; j++)
                    {
                        Console.WriteLine(tablou_argumente[i][j]);
                    }
                    Console.WriteLine("\n");
                }


            }

     
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string _numeFisier = ConfigurationManager.AppSettings["_NumeFisier"];
            Administrare_informatii AdministrareSoldati = new Administrare_informatii(numeFisier);
            Administrare_informatii AdministrareArmament = new Administrare_informatii(_numeFisier);

        
            int nrSoldati = 0;
            int nrArmament = 0;
            AdministrareSoldati.GetSoldati(out nrSoldati);
            AdministrareArmament.Get_Armament(out nrArmament);

            Soldati soldat = new Soldati();
            Arme Arme = new Arme();

            
            string optiune;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("------------------------F. Afisare soldati din fisier------------------------");
                Console.WriteLine("------------------------S. Inregistrare soldat       ------------------------");
                Console.WriteLine("------------------------A. Afisare armament          ------------------------");
                Console.WriteLine("------------------------H. Inregistrare arme         ------------------------");
                Console.WriteLine("------------------------C. Citire nume soldat        ------------------------");
                Console.WriteLine("------------------------K. Citire armament           ------------------------");
                Console.WriteLine("------------------------L. Cautare soldat            ------------------------");
                Console.WriteLine("------------------------Z. Cautare arma              ------------------------");
                Console.WriteLine("------------------------X. Inchidere program         ------------------------");
                Console.WriteLine("------------------------Alegeti o optiune            ------------------------\n");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "F":
                        Soldati[] soldati = AdministrareSoldati.GetSoldati(out nrSoldati);
                        AfisareSoldati(soldati, nrSoldati);
                        break;
                    case "A":
                        Arme[] arme = AdministrareArmament.Get_Armament(out nrArmament);
                        AfisareArmament(arme, nrArmament);
                        break;
                    case "S":
                        //nrSoldati = nrSoldati + 1;
                        AdministrareSoldati.AddSoldat(soldat);
                        break;
                    case "H":
                        //nrArmament = nrArmament + 1;
                        AdministrareArmament.AddArmament(Arme);
                        break;
                    case "C":
                        /*Laborator 3. Citire date*/
                        soldat.Citire_Soldat();
                        Console.WriteLine(soldat.InformatiiSoldat());
                        break;
                    case "K":
                        /*Laborator 4. Citire armament*/
                        Console.WriteLine(AdministrareSoldati.Cautare_in_fisier("Bianca").InformatiiSoldat());
                        Arme.Citire_Armament();
                        break;
                    case "L":
                        /*Laborator 3. Cautare dupa criterii*/
                        string SoldatCautat = Console.ReadLine();
                        Console.WriteLine(AdministrareSoldati.Cautare_in_fisier(SoldatCautat).InformatiiSoldat());
                        break;
                    case "Z":
                        /*Laborator 4. Cautare dupa criterii*/
                        string ArmamentCautat = Console.ReadLine();
                        Console.WriteLine(AdministrareArmament.Cautare_in_fisier(ArmamentCautat).InformatiiSoldat());
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();


        }
        public static void AfisareSoldati(Soldati[] soldati, int nrSoldati)
        {
            Console.WriteLine("Soldatii sunt:");
            for (int contor = 0; contor < nrSoldati; contor++)
            {
                string infoStudent = string.Format("Soldatul cu numele {0} {1} este nascut la data de  {2} si se afla la unitatea {3}",
                   (soldati[contor].GetNumeSoldat() ?? " NECUNOSCUT "),
                   (soldati[contor].GetPrenumeSoldat() ?? " NECUNOSCUT "),
                   (soldati[contor].GetDataNasterii() ?? " NECUNOSCUT "),
                   (soldati[contor].GetUnitate() ?? " NECUNOSCUT "));

                Console.WriteLine(infoStudent);
            }
        }

        public static void AfisareArmament(Arme[] arme, int nrArme)
        {
            Console.WriteLine("Echipamentele sunt:");
            for (int contor = 0; contor < nrArme; contor++)
            {
                string infoArme = string.Format("Categorie: {0} \n Model: {1} \n Tip: {2} \n Calibru: {3} \n Detalii arma: {4} \n Cantitate: {5}",
                   (arme[contor].GetCategorie() ?? " NECUNOSCUT "),
                   (arme[contor].GetModel() ?? " NECUNOSCUT "),
                   (arme[contor].GetTip() ?? " NECUNOSCUT "),
                   (arme[contor].GetCalibru() ?? " NECUNOSCUT "),
                   (arme[contor].GetDetalii() ?? " NECUNOSCUT "),
                   arme[contor].GetNumarArmament());

                Console.WriteLine(infoArme);
            }
        }
    }
}
