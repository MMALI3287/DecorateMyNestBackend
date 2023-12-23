using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class CatalogCategoryRepo : Repo, IRepo<CatalogCategory, int, CatalogCategory>
    {
        public CatalogCategory Create(CatalogCategory obj)
        {
            contextDb.CatalogCategories.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var catalogCategory = Read(id);
            contextDb.CatalogCategories.Remove(catalogCategory);
            return contextDb.SaveChanges() > 0;
        }

        public List<CatalogCategory> Read()
        {
            return contextDb.CatalogCategories.ToList();

        }

        public CatalogCategory Read(int id)
        {
            return contextDb.CatalogCategories.Find(id);
        }

        public CatalogCategory Update(CatalogCategory obj)
        {
            var extCatalogCategory = Read(obj.CatalogCategoryId);
            contextDb.Entry(extCatalogCategory).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
