using System;
using System.Collections.Generic;

namespace Tranzactii
{
    public class Tranzactie
    {
        private const char SEPARATOR_SIR = '|';

        private DateTime _data;
        private double _suma;
        private string _tip;
        private string _categorie;
        private string _descriere;

        public List<string> CategoriiVenituri = new List<string>() { "Alocatie", "Salariu", "Bonus", "Altele" };

        public List<string> CategoriiCheltuieli = new List<string>() { "Mancare", "Viata sociala", "Dezvoltare personala", "Transport", "Cultura", "Casa",
            "Imbracaminte", "Sanatate", "Educatie", "Cadou", "Altele"};

        public List<string> TipuriTranzactii = new List<string>() { "Venit", "Cheltuiala" };

        public DateTime Data { get => _data; set => _data = value; }
        public double Suma { get => _suma; set => _suma = value; }
        public string Tip { get => _tip; set => _tip = value; }
        public string Categorie { get => _categorie; set => _categorie = value; }
        public string Descriere { get => _descriere; set => _descriere = value; }

        public int Id { get; set; }

        public Tranzactie()
        {

        }

        public Tranzactie(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_SIR);

            _tip = dateFisier[0];
            _categorie = dateFisier[1];
            _descriere = dateFisier[2];
            _suma = double.Parse(dateFisier[3]);
            _data = DateTime.Parse(dateFisier[4]);
        }

        public Tranzactie(string tip, string categorie, string descriere, double suma, DateTime data)
        {
            _tip = tip;
            _categorie = categorie;
            _descriere = descriere;
            _suma = suma;
            _data = data;
        }

        public string FormatareSir()
        {
            string obiectTranzactie = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                SEPARATOR_SIR,
                _tip,
                _categorie,
                _descriere,
                _suma,
                _data);
            return obiectTranzactie;
        }
    }
}

