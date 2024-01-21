namespace DAL.Interfaces
{
    public interface IReadByValue<Type, ID, RET>
    {
        Type ReadByValue(ID value);
    }
}
