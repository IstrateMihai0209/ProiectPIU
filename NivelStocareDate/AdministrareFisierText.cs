using System;
using System.Collections.Generic;
using System.IO;
using Tranzactii;

namespace NivelStocareDate
{
    public class AdministrareFisierText
    {
        private const char SEPARATOR_SIR = '|';
        private const int NR_MAX_TRANZACTII = 50;
        private const int ID_PRIMA_TRANZACTIE = 1;

        private string numeFisier;

        public AdministrareFisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AdaugaTranzactie(Tranzactie tranzactie)
        {
            tranzactie.Id = GetId();

            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(tranzactie.FormatareSir());
            }
        }

        public List<Tranzactie> GetTranzactii()
        {
            List<Tranzactie> tranzactii = new List<Tranzactie>();

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    var tranzactieCitita = CreazaTranzactieDinFisier(linieFisier);
                    tranzactii.Add(tranzactieCitita);
                }
            }

            return tranzactii;
        }


        public Tranzactie[] GetTranzactii(out int nrTranzactii)
        {
            Tranzactie[] tranzactii = new Tranzactie[NR_MAX_TRANZACTII];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrTranzactii = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    tranzactii[nrTranzactii++] = new Tranzactie(linieFisier);
                }
            }

            return tranzactii;
        }

        public Tranzactie GetTranzactie(string descriere)
        {
            Tranzactie tranzactie;
            using(StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while((linieFisier = streamReader.ReadLine()) != null)
                {
                    tranzactie = CreazaTranzactieDinFisier(linieFisier);
                    if (tranzactie.Descriere == descriere)
                        return tranzactie;
                }

                return new Tranzactie();
            }    
        }

        public int GetNumarTranzactii()
        {
            int nrTranzactii = 0;
            using(StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while((linieFisier = streamReader.ReadLine()) != null)
                {
                    nrTranzactii++;
                }
            }
            return nrTranzactii;
        }

        private Tranzactie CreazaTranzactieDinFisier(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_SIR);

            return new Tranzactie(
                dateFisier[0],
                dateFisier[1],
                dateFisier[2],
                Double.Parse(dateFisier[3]),
                DateTime.Parse(dateFisier[4]));
        }

        private int GetId()
        {
            int idTranzactie = ID_PRIMA_TRANZACTIE;

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Tranzactie tranzactie = new Tranzactie(linieFisier);
                    idTranzactie = tranzactie.Id++;
                }
            }

            return idTranzactie;
        }
    }
}