using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class MaterialTransactionRepo : Repo, IRepo<MaterialTransaction, int, MaterialTransaction>
    {
        public MaterialTransaction Create(MaterialTransaction obj)
        {
            contextDb.MaterialTransactions.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var materialTransaction = Read(id);
            contextDb.MaterialTransactions.Remove(materialTransaction);
            return contextDb.SaveChanges() > 0;
        }

        public List<MaterialTransaction> Read()
        {
            return contextDb.MaterialTransactions.ToList();
        }

        public MaterialTransaction Read(int id)
        {
            return contextDb.MaterialTransactions.Find(id);
        }

        public MaterialTransaction Update(MaterialTransaction obj)
        {
            var extMaterialTransaction = Read(obj.TransactionId);
            contextDb.Entry(extMaterialTransaction).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
