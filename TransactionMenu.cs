using System;
using System.Collections.Generic;

namespace ProiectPIU
{
    class TransactionMenu
    {
        private List<Transaction> _transactions = new List<Transaction>();

        public List<Transaction> Transactions { get => _transactions; set => _transactions = value; }

        public void ShowTransactions()
        {
            DateTime currentMonth = DateTime.Now;
            double totalAmount = 0;

            Console.WriteLine($"Tranzactii {currentMonth.ToString("MMMM yyyy")}:\n");

            foreach (Transaction transaction in _transactions)
            {
                if (transaction.Date.Month == currentMonth.Month && transaction.Date.Year == currentMonth.Year)
                {
                    Console.WriteLine($"{transaction.Date.ToString("dd/MM/yyyy")}\t" +
                        $"{transaction.Amount.ToString("C")}\t" +
                        $"{transaction.Category}\t" +
                        $"{transaction.Description}");

                    totalAmount += transaction.Amount;
                }
            }

            Console.WriteLine($"\nTotal cheltuieli: {totalAmount.ToString("C")}\n");
        }
    }
}
