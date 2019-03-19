using System.Collections.Generic;
using DTO;

namespace DAO
{
    public interface ISpNhomDao
    {
        void Delete(SpNhom obj);
        List<SpNhom> GetAll();
        SpNhom GetById(int id);
        SpNhom Insert(SpNhom obj);
        void Update(SpNhom obj);
    }
}