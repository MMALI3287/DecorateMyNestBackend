using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ArchivedProjectRepo : Repo, IRepo<ArchivedProject, int, ArchivedProject>
    {
        public ArchivedProject Create(ArchivedProject obj)
        {
            contextDb.ArchivedProjects.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var archivedProject = Read(id);
            contextDb.ArchivedProjects.Remove(archivedProject);
            return contextDb.SaveChanges() > 0;
        }

        public List<ArchivedProject> Read()
        {
            return contextDb.ArchivedProjects.ToList();
        }

        public ArchivedProject Read(int id)
        {
            return contextDb.ArchivedProjects.Find(id);
        }

        public ArchivedProject Update(ArchivedProject obj)
        {
            var extArchivedProject = Read(obj.ProjectId);
            contextDb.Entry(extArchivedProject).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
