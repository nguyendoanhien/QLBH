using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class SpLoaiBus
    {
        private static readonly SpLoaiDao SpLoai;

        static SpLoaiBus()
        {
            SpLoai = new SpLoaiDao();
        }

        public static void Delete(SpLoai obj)
        {
            SpLoai.Delete(obj);
        }

        public static List<SpLoai> GetAll()
        {
            return SpLoai.GetAll();
        }

        public static SpLoai GetById(int id)
        {
            return SpLoai.GetById(id);
        }

        public static SpLoai Insert(SpLoai obj)
        {
            return SpLoai.Insert(obj);
        }

        public static void Update(SpLoai obj)
        {
            SpLoai.Update(obj);
        }
    }
}