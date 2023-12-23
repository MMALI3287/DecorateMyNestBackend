using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class MaterialInventoryRepo : Repo, IRepo<MaterialInventory, int, MaterialInventory>
    {
        public MaterialInventory Create(MaterialInventory obj)
        {
            contextDb.MaterialInventories.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var materialInventory = Read(id);
            contextDb.MaterialInventories.Remove(materialInventory);
            return contextDb.SaveChanges() > 0;
        }

        public List<MaterialInventory> Read()
        {
            return contextDb.MaterialInventories.ToList();
        }

        public MaterialInventory Read(int id)
        {
            return contextDb.MaterialInventories.Find(id);
        }

        public MaterialInventory Update(MaterialInventory obj)
        {
            var extMaterialInventory = Read(obj.MaterialId);
            contextDb.Entry(extMaterialInventory).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
