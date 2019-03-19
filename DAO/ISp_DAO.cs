using System.Collections.Generic;
using DTO;

namespace DAO
{
    public interface ISpDao
    {
        void Delete(Sp obj);
        List<Sp> GetAll();
        Sp GetById(int id);
        Sp Insert(Sp obj);
        void Update(Sp obj);
    }
}