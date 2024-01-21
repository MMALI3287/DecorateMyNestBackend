using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Client, int, Client> ClientData() => new ClientRepo();

        public static IRepo<Reservation, int, Reservation> ReservationData() => new ReservationRepo();

        public static IRepo<ReservationTransaction, int, ReservationTransaction> ReservationTransactionData() => new ReservationTransactionRepo();

        public static IRepo<SalaryTransaction, int, SalaryTransaction> SalaryTransactionData() => new SalaryTransactionRepo();

        public static IRepo<Admin, int, Admin> AdminData() => new AdminRepo();

        public static IRepo<ChatList, int, ChatList> ChatListData() => new ChatListRepo();

        public static IRepo<Message, int, Message> MessageData() => new MessageRepo();

        public static IRepo<Notification, int, Notification> NotificationData() => new NotificationRepo();

        public static IRepo<MaterialInventory, int, MaterialInventory> MaterialInventoryData() => new MaterialInventoryRepo();

        public static IRepo<MaterialTransaction, int, MaterialTransaction> MaterialTransactionData() => new MaterialTransactionRepo();

        public static IRepo<InstallmentTransaction, int, InstallmentTransaction> InstallmentTransactionData() => new InstallmentTransactionRepo();

        public static IRepo<ArchivedProject, int, ArchivedProject> ArchivedProjectData() => new ArchivedProjectRepo();

        public static IRepo<Catalog, int, Catalog> CatalogData() => new CatalogRepo();

        public static IRepo<CatalogCategory, int, CatalogCategory> CatalogCategoryData() => new CatalogCategoryRepo();

        public static IRepo<FinancialTransaction, int, FinancialTransaction> FinancialTransactionData() => new FinancialTransactionRepo();

        public static IRepo<EmployeeRoster, int, EmployeeRoster> EmployeeRosterData() => new EmployeeRosterRepo();

        public static IRepo<InProgressProject, int, InProgressProject> InProgressProjectData() => new InProgressProjectRepo();

        public static IRepo<Order, int, Order> OrderData() => new OrderRepo();

        public static IRepo<Appointment, int, Appointment> AppointmentData() => new AppoitmentRepo();

        public static IRepo<Vendor, int, Vendor> VendorData() => new VendorRepo();

        public static IRepo<Authentication, int, Authentication> AuthenticationData() => new AuthenticationRepo();

        public static IAuth<Token> AuthData() => new AuthenticationRepo();

        public static IRegi<Authentication, string> RegistrationData2() => new AuthenticationRepo();

        public static IRepo<Token, string, Token> TokenData() => new TokenRepo();



    }
}