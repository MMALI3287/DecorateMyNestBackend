using DAL.Interfaces;
using DAL.Models;
using System.Linq;

namespace DAL.Repos
{
    internal class InProgressProjectRepo : Repo, IRepo<InProgressProject, int, InProgressProject>
    {
        public InProgressProject Create(InProgressProject obj)
        {
            contextDb.InProgressProjects.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var client = Read(id);
            contextDb.InProgressProjects.Remove(client);
            return contextDb.SaveChanges() > 0;
        }

        public System.Collections.Generic.List<InProgressProject> Read()
        {
            return contextDb.InProgressProjects.ToList();
        }

        public InProgressProject Read(int id)
        {
            return contextDb.InProgressProjects.Find(id);
        }

        public InProgressProject Update(InProgressProject obj)
        {
            var extInProgressProject = Read(obj.ProjectId);
            contextDb.Entry(extInProgressProject).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
