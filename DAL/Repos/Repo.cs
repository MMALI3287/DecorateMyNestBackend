namespace DAL.Repos
{
    internal class Repo
    {
        internal ContextDb contextDb;

        internal Repo()
        {
            contextDb = new ContextDb();
        }
    }
}