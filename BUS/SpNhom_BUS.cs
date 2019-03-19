using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class SpNhom_BUS
    {
        private static readonly ISpNhomDao Spnhom;

        static SpNhom_BUS()
        {
            Spnhom = new SpNhomDao();
        }

        public static void Delete(SpNhom obj)
        {
            Spnhom.Delete(obj);
        }

        public static List<SpNhom> GetAll()
        {
            return Spnhom.GetAll();
        }

        public static SpNhom GetById(int id)
        {
            return Spnhom.GetById(id);
        }

        public static SpNhom Insert(SpNhom obj)
        {
            return Spnhom.Insert(obj);
        }

        public static void Update(SpNhom obj)
        {
            Spnhom.Update(obj);
        }
    }
}