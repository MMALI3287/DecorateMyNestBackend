namespace DAL.Interfaces
{
    public interface IRegi<TYPE, ID>
    {
        TYPE Read(ID id);
    }
}