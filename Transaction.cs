using System;

namespace ProiectPIU
{
    class Transaction
    {
        private DateTime _date;
        private double _amount;
        private string _category;
        private string _description;

        public DateTime Date { get => _date; set => _date = value; }
        public double Amount { get => _amount; set => _amount = value; }
        public string Category { get => _category; set => _category = value; }
        public string Description { get => _description; set => _description = value; }

        public Transaction(DateTime date, double amount, string category, string description)
        {
            _date = date;
            _amount = amount;
            _category = category;
            _description = description;
        }
    }
}
