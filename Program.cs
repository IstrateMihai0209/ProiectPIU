using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactionMenu = new TransactionMenu();
            
            for(int i = 0; i <= 5; i++)
            {
                var newTransaction = new Transaction(DateTime.Now, 100, "Food", "Meniu");
                transactionMenu.Transactions.Add(newTransaction);
            }

            transactionMenu.ShowTransactions();
            Console.ReadLine();
        }
    }
}
