using System;
using System.Collections.Generic;

namespace Tranzactii
{
    public class MeniuTranzactii
    {
        private List<Tranzactie> _tranzactii = new List<Tranzactie>();

        public List<Tranzactie> Tranzactii { get => _tranzactii; set => _tranzactii = value; }

        public Tranzactie CitireTranzactie()
        {
            Tranzactie tranzactieNoua = new Tranzactie();
            int optiune;

            // Tip
            Console.WriteLine("Alegeti tipul tranzactiei: ");
            for (int i = 0; i < tranzactieNoua.TipuriTranzactii.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tranzactieNoua.TipuriTranzactii[i]}");
            }

            do
            {
                optiune = Convert.ToInt32(Console.ReadLine()) - 1;
                if (optiune >= 0 && optiune < tranzactieNoua.TipuriTranzactii.Count)
                {
                    tranzactieNoua.Tip = tranzactieNoua.TipuriTranzactii[optiune];
                }
            } while (tranzactieNoua.Tip == null);

            // Categorie
            Console.WriteLine("Alegeti categoria tranzactiei: ");
            List<string> categorii = tranzactieNoua.Tip == "Venit" ? tranzactieNoua.CategoriiVenituri : tranzactieNoua.CategoriiCheltuieli;
            for (int i = 0; i < categorii.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categorii[i]}");
            }

            do
            {
                optiune = Convert.ToInt32(Console.ReadLine()) - 1;
                if (optiune >= 0 && optiune < categorii.Count)
                {
                    tranzactieNoua.Categorie = categorii[optiune];
                }
            } while (tranzactieNoua.Categorie == null);

            // Suma
            Console.WriteLine("Notati valoarea tranzactiei: ");
            tranzactieNoua.Suma = Convert.ToDouble(Console.ReadLine());

            // Descriere
            Console.WriteLine("Adaugati o descriere a tranzactiei (optional): ");
            tranzactieNoua.Descriere = Console.ReadLine();

            // Data
            Console.WriteLine("Doriti sa modificati data tranzactiei? [Y/N]");
            string raspuns = Console.ReadLine();
            if (raspuns.ToUpper() == "Y")
            {
                Console.WriteLine("Anul: ");
                int an = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Luna: ");
                int luna = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ziua: ");
                int zi = Convert.ToInt32(Console.ReadLine());

                tranzactieNoua.Data = new DateTime(an, luna, zi);
            }
            if (raspuns.ToUpper() == "N")
            {
                tranzactieNoua.Data = DateTime.Now;
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(tranzactieNoua.Tip);
            Console.WriteLine(tranzactieNoua.Categorie);
            Console.WriteLine(tranzactieNoua.Suma);
            Console.WriteLine(tranzactieNoua.Descriere);
            Console.WriteLine(tranzactieNoua.Data);
            return tranzactieNoua;
        }

        public void AfisareTranzactii()
        {
            DateTime dataCurenta = DateTime.Now;
            double totalVenituri = 0;
            double totalCheltuieli = 0;

            Console.WriteLine($"Tranzactii {dataCurenta.ToString("MMMM yyyy")}:\n");

            foreach (var tranzactie in _tranzactii)
            {
                if (tranzactie.Data.Month == dataCurenta.Month && tranzactie.Data.Year == dataCurenta.Year)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"{tranzactie.Tip}\n{tranzactie.Categorie}\n{tranzactie.Descriere}" +
                        $"\n{tranzactie.Suma}\n{tranzactie.Data}");

                    if(tranzactie.Tip == tranzactie.TipuriTranzactii[0])
                    {
                        totalVenituri += tranzactie.Suma;
                    }
                    else
                    {
                        totalCheltuieli += tranzactie.Suma;
                    }
                }
            }

            Console.WriteLine($"\nTotal venituri: {totalVenituri.ToString()} lei");
            Console.WriteLine($"\nTotal cheltuieli: {totalCheltuieli.ToString()} lei\n");
        }

        public List<Tranzactie> GetVenituri()
        {
            List<Tranzactie> venituri = new List<Tranzactie>();
            foreach(var tranzactie in _tranzactii)
            {
                if(tranzactie.Tip == tranzactie.TipuriTranzactii[0])
                {
                    venituri.Add(tranzactie);
                }
            }

            return venituri;
        }

        public List<Tranzactie> GetCheltuieli()
        {
            List<Tranzactie> cheltuieli = new List<Tranzactie>();
            foreach (var tranzactie in _tranzactii)
            {
                if (tranzactie.Tip == "Cheltuiala")
                {
                    cheltuieli.Add(tranzactie);
                }
            }

            return cheltuieli;
        }
    }
}