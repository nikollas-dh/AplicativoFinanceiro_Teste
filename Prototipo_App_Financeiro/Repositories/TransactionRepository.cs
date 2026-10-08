using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;
using LiteDB;
using System.Linq;
using Prototipo_App_Financeiro.Models;

namespace Prototipo_App_Financeiro.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly LiteDatabase db;
        private readonly string collectionName;
        public TransactionRepository()
        {
            db = new LiteDatabase("Filename=C:/users/AppData/database.db;Connection=Shared");
            db.Dispose();
        }

        public List<Transaction> GetAll()
        {
            return (List<Transaction>)db
                .GetCollection<Transaction>(collectionName)
                .Query()
                .OrderByDescending(o => o.Date);
        }
        public void Add(Transaction transaction)
        {
            var col = db.GetCollection<Transaction>(collectionName);
            col.Insert(transaction);

            col.EnsureIndex(a => a.Date);
          
        }

        public void Update(Transaction transaction)
        {
            var col = db.GetCollection<Transaction>(collectionName);
            col.Update(transaction);
        }
        public void Delete(Transaction transaction)
        {

            var col = db.GetCollection<Transaction>(collectionName);
            col.Delete(transaction.Id);
        }
    }
}
