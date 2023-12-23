using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Client, int, Client> ClientData()
        {
            return new ClientRepo();
        }
    }
}