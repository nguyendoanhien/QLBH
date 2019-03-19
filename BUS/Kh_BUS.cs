#region

using System.Collections.Generic;
using DAO;
using DTO;

#endregion

namespace BUS
{
    public class KhBus
    {
        private static readonly KhDao Kh;

        static KhBus()
        {
            Kh = new KhDao();
        }

        public static void Delete(Kh obj)
        {
            Kh.Delete(obj);
        }

        public static List<Kh> GetAll()
        {
            return Kh.GetAll();
        }

        public static Kh GetById(int id)
        {
            return Kh.GetById(id);
        }

        public static Kh Insert(Kh obj)
        {
            return Kh.Insert(obj);
        }

        public static void Update(Kh obj)
        {
            Kh.Update(obj);
        }
    }
}