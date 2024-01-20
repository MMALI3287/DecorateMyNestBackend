using Microsoft.EntityFrameworkCore;

namespace DAL.Repos
{
    internal class Repo
    {
        internal ContextDb contextDb;

        internal Repo(DbContextOptions<ContextDb> options) : base(options)
        {
            contextDb = new ContextDb(options);
        }
    }
}