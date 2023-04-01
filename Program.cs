using System;
using System.Configuration;
using Tranzactii;

namespace ProiectPIU
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareFisierText fisierAdmin = new AdministrareFisierText(numeFisier);
            
            MeniuTranzactii meniuTranzactii = new MeniuTranzactii();
            meniuTranzactii.Tranzactii = fisierAdmin.GetTranzactii(); 

            string optiune;
            do
            {
                Console.WriteLine("I. Adaugare tranzactie");
                Console.WriteLine("A. Afisare tranzactii luna curenta");

                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "I":
                        Tranzactie tranzactie = meniuTranzactii.CitireTranzactie();
                        meniuTranzactii.Tranzactii.Add(tranzactie);
                        fisierAdmin.AdaugaTranzactie(tranzactie);
                        break;

                    case "A":
                        meniuTranzactii.AfisareTranzactii();
                        break;

                    case "C":

                        break;

                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }
    }
}