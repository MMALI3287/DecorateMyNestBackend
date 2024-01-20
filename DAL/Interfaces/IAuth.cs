namespace DAL.Interfaces
{
    public interface IAuth<Ret>
    {
        Ret Authenticate(string username, string password);
        //Ret HasExtToken(string Username);
    }
}
