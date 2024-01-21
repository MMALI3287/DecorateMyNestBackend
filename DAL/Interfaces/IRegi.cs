namespace DAL.Interfaces
{
    public interface IRegi<TYPE, ID>
    {
        TYPE GetAuthenticationByUsername(ID id);
    }
}