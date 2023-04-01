using System;
using System.Collections.Generic;
using System.IO;
using Aplicatie;

namespace Tranzactii
{
    public class AdministrareFisierText
    {
        private string numeFisier;

        public AdministrareFisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AdaugaTranzactie(Tranzactie tranzactie)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(tranzactie.FormatareSir());
            }
        }

        public List<Tranzactie> GetTranzactii()
        {
            List<Tranzactie> tranzactii = new List<Tranzactie>();
        
            using(StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while((linieFisier = streamReader.ReadLine()) != null)
                {
                    var tranzactieCitita = CreazaTranzactieDinFisier(linieFisier);
                    tranzactii.Add(tranzactieCitita);
                }
            }

            return tranzactii;
        }

        private Tranzactie CreazaTranzactieDinFisier(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(Utilitati.SeparatorSir);

            return new Tranzactie(
                dateFisier[0],
                dateFisier[1],
                dateFisier[2],
                Double.Parse(dateFisier[3]),
                DateTime.Parse(dateFisier[4]));
        }

        //public Student[] GetStudenti(out int nrStudenti)
        //{
        //    Student[] studenti = new Student[NR_MAX_STUDENTI];

        //    // instructiunea 'using' va apela streamReader.Close()
        //    using (StreamReader streamReader = new StreamReader(numeFisier))
        //    {
        //        string linieFisier;
        //        nrStudenti = 0;

        //        // citeste cate o linie si creaza un obiect de tip Student
        //        // pe baza datelor din linia citita
        //        while ((linieFisier = streamReader.ReadLine()) != null)
        //        {
        //            studenti[nrStudenti++] = new Student(linieFisier);
        //        }
        //    }

        //    return studenti;
        //}
    }
}