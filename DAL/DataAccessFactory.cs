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

        public static IRepo<Reservation, int, Reservation> ReservationData()
        {
            return new ReservationRepo();
        }

        public static IRepo<ReservationTransaction, int, ReservationTransaction> ReservationTransactionData()
        {
            return new ReservationTransactionRepo();
        }