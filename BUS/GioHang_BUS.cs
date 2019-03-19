using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class GioHangBus
    {
        private static readonly GioHangDao GioHang;

        static GioHangBus()
        {
            GioHang = new GioHangDao();
        }

        public static void Delete(GioHang obj)
        {
            GioHang.Delete(obj);
        }

        public static List<GioHang> GetAll()
        {
            return GioHang.GetAll();
        }

        public static GioHang GetById(int id)
        {
            return GioHang.GetById(id);
        }

        public static GioHang Insert(GioHang obj)
        {
            return GioHang.Insert(obj);
        }

        public static void Update(GioHang obj)
        {
            GioHang.Update(obj);
        }
    }
}