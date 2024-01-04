// Ignore Spelling: RET
// Ignore Spelling: Repo

using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IRepo<Type, ID, RET>
    {
        RET Create(Type obj);

        List<Type> Read();

        Type Read(ID id);

        RET Update(Type obj);

        bool Delete(ID id);
    }
}