
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

               

                //functia group by ne grupeaza itemi sirului dupa un anumit criteriu, in momentul de fata ne grupeaza dupa  litera                            name.first() care este primul caracter din string
                //deci grupam argumentele dupa prima litera, dupa care functia count numara cate grupari din acestea sunt,                              pentru a stii cate linii vom avea nevoie
                //(de ex daca avem albert bianca beniamin calin sebi vom avea 4 linii pe care trebuie sa ii punem pe cei cu a,                          cu b,c si d) 
                string[][] tabela_in_scara = new string[args.GroupBy(name => name.First()).Count()][];
                int i = 0;
                //Primul foreach contine tot functia group by urmata de order by, dupa care to List(aceste functii se realizeaza                        de la stanga la dreapta), in traducere libera
                //grupam argumentele dupa prima litera, dupa care ii si ordonam. si in final ii transformam in lista care va fi                         parcursa element cu element de catre foreach
                foreach (var argumente in args.GroupBy(name => name.First()).OrderBy(g => g.Key).ToList())
                {
                    //argumente se comporta cumva ca o lista in care avem cheia primara(prima litera) si elementele care incep                          cu litera aceea
                    int j = 0;
                    //aici am facut un lucru asemanator ca si la declararea tabela_in_scara, am setat dinainte ce marime va avea                        linia din tabloul nostru in scari
                    tabela_in_scara[i] = new string[argumente.Count()];
                    //acum ca trecem prin fiecare lista de argumente care incep cu o litera, putem trece prin fiecare element                           din lista cu acest foreach (care ne face si
                    //o sortare dupa nume) care ne aduce intr-o lista "parcusibila" toate elementele care au aceeasi prima                              litera.
                    foreach (var argument in argumente.OrderBy(name => name).ToList())
                    {
                        tabela_in_scara[i][j] = argument;
                        j++;
                    }
                    i++;
                }
                foreach (var linie in tabela_in_scara)
                {
                    foreach (var item in linie)
                    {
                        Console.WriteLine(item + " ");
                    }
                    Console.WriteLine();
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
                Console.WriteLine("------------------------A. Afisare armament          ------------------------");
                Console.WriteLine("------------------------S. Inregistrare soldat       ------------------------");
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
                        Console.WriteLine(AdministrareArmament.Cautare_in_fisier_arme(ArmamentCautat).InformatiiArmament());
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
                   (soldati[contor].NumeSoldat ?? " NECUNOSCUT "),
                   (soldati[contor].PrenumeSoldat ?? " NECUNOSCUT "),
                   (soldati[contor].DataNasteriiSoldati ?? " NECUNOSCUT "),
                   (soldati[contor].UnitateSoldati ?? " NECUNOSCUT "));

                Console.WriteLine(infoStudent);
            }
        }

        public static void AfisareArmament(Arme[] arme, int nrArme)
        {
            Console.WriteLine("Echipamentele sunt:");
            for (int contor = 0; contor < nrArme; contor++)
            {
                string infoArme = string.Format("Categorie: {0} \n Model: {1} \n Tip: {2} \n Calibru: {3} \n Detalii arma: {4} \n Cantitate: {5}",
                   (arme[contor].Categorie ?? " NECUNOSCUT "),
                   (arme[contor].Model_arma ?? " NECUNOSCUT "),
                   (arme[contor].TipArma ?? " NECUNOSCUT "),
                   (arme[contor].CalibruArma ?? " NECUNOSCUT "),
                   (arme[contor].DetaliiArma ?? " NECUNOSCUT "),
                   arme[contor].NumarArme);

                Console.WriteLine(infoArme);
            }
        }
    }
}
