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

        public static IRepo<SalaryTransaction, int, SalaryTransaction> SalaryTransactionData()
        {
            return new SalaryTransactionRepo();
        }

        public static IRepo<Admin, int, Admin> AdminData()
        {
            return new AdminRepo();
        }

        public static IRepo<ChatList, int, ChatList> ChatListData()
        {
            return new ChatListRepo();
        }

        public static IRepo<Message, int, Message> MessageData()
        {
            return new MessageRepo();
        }

        public static IRepo<Notification, int, Notification> NotificationData()
        {
            return new NotificationRepo();
        }

        public static IRepo<MaterialInventory, int, MaterialInventory> MaterialInventoryData()
        {
            return new MaterialInventoryRepo();
        }

        public static IRepo<MaterialTransaction, int, MaterialTransaction> MaterialTransactionData()
        {
            return new MaterialTransactionRepo();
        }

        public static IRepo<InstallmentTransaction, int, InstallmentTransaction> InstallmentTransactionData()
        {
            return new InstallmentTransactionRepo();
        }

        public static IRepo<ArchivedProject, int, ArchivedProject> ArchivedProjectData()
        {
            return new ArchivedProjectRepo();
        }

        public static IRepo<Catalog, int, Catalog> CatalogData()
        {
            return new CatalogRepo();
        }

        public static IRepo<CatalogCategory, int, CatalogCategory> CatalogCategoryData()
        {
            return new CatalogCategoryRepo();
        }

        public static IRepo<FinancialTransaction, int, FinancialTransaction> FinancialTransactionData()
        {
            return new FinancialTransactionRepo();
        }

        public static IRepo<EmployeeRoster, int, EmployeeRoster> EmployeeRosterData()
        {
            return new EmployeeRosterRepo();
        }


        public static IRepo<InProgressProject, int, InProgressProject> InProgressProjectData()
        {
            return new InProgressProjectRepo();
        }

        public static IRepo<Order, int, Order> OrderData()
        {
            return new OrderRepo();
        }

        public static IRepo<Appointment, int, Appointment> AppointmentData()
        {
            return new AppoitmentRepo();
        }

        public static IRepo<Vendor, int, Vendor> VendorData()
        {
            return new VendorRepo();
        }

        public static IRepo<Authentication, int, Authentication> AuthenticationData()
        {
            return new AuthenticationRepo();
        }

        public static IAuth<Token> AuthData()
        {
            return new AuthenticationRepo();
        }

        public static IRegi<Authentication, string> RegistrationData2()
        {
            return new AuthenticationRepo();
        }

        public static IRepo<Token, string, Token> TokenData() => new TokenRepo();

    }
}