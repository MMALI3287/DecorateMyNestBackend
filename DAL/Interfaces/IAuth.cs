namespace DAL.Interfaces
{
    public interface IAuth<Ret>
    {
        bool Authenticate(string username, string password);
        Ret HasExtToken(string Username);
    }
}
