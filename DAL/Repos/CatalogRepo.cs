using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class CatalogRepo : Repo, IRepo<Catalog, int, Catalog>
    {
        public Catalog Create(Catalog obj)
        {
            contextDb.Catalogs.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var catalog = Read(id);
            contextDb.Catalogs.Remove(catalog);
            return contextDb.SaveChanges() > 0;
        }

        public List<Catalog> Read()
        {
            return contextDb.Catalogs.ToList();
        }

        public Catalog Read(int id)
        {
            return contextDb.Catalogs.Find(id);
        }

        public Catalog Update(Catalog obj)
        {
            var extCatalog = Read(obj.CatalogId);
            contextDb.Entry(extCatalog).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
